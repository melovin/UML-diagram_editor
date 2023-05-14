using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using UMLdiagrams.Arrows;
using UMLdiagrams.Helpers;
using UMLdiagrams.Myclasses;
using System.Runtime.CompilerServices;
using System.Drawing.Drawing2D;

namespace UMLdiagrams
{ 
    public partial class Form1 : Form
    {
        public ContentHolder ContentHolder = new ContentHolder();
        private DiagramClass Selected { get; set; }
        private Graphics D { get; set; }
        private bool ArrowCreation { get; set; } = false;
        private List<ArrowArgs> Clicks { get; set; } = new List<ArrowArgs>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_addClass_Click(object sender, EventArgs e)
        {
            DiagramClass newClass = new DiagramClass();

            List<string> allNames = ContentHolder.Diagrams.Select(diagram => diagram.Name).ToList();

            this.ArrowCreation = false;

            EditDiagramClassForm diagramClass = new EditDiagramClassForm(newClass, allNames);
            diagramClass.ShowDialog();

            if (diagramClass.DialogResult == DialogResult.OK)
            {
                newClass.Selected = true;
                this.ContentHolder.Diagrams.Add(newClass);

                this.D = pictureBox.CreateGraphics();
            }

            this.pictureBox.Invalidate();
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            DeleteAll delete = new DeleteAll();
            delete.ShowDialog();
            if (delete.DialogResult == DialogResult.OK)
            {
                this.ContentHolder.Diagrams.Clear();
                this.ContentHolder.Arrows.Clear();
                this.ArrowCreation = false;
                this.pictureBox.Refresh();
            }
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (Arrow_Template arrow in this.ContentHolder.Arrows)
            {
                arrow.Draw(e.Graphics);
            }

            foreach (DiagramClass item in ContentHolder.Diagrams)
            {
                item.Draw(e.Graphics);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (this.Selected is not null)
            {
                List<string> allNames = ContentHolder.Diagrams.Select(diagram => diagram.Name).ToList();
                EditDiagramClassForm form = new EditDiagramClassForm(this.Selected, allNames);
                this.ArrowCreation = false;
                form.ShowDialog();
            }
            else
            {
                foreach (var item in this.ContentHolder.Arrows)
                {
                    if(item.IsSelected)
                    {
                        ConnectionForm form = new ConnectionForm(this.Clicks, this.ContentHolder.Arrows);
                        form.ShowDialog();
                        if(form.DialogResult == DialogResult.OK)
                        {
                            this.ContentHolder.Arrows.Remove(item);
                            Clicks.Clear(); //udelat neco s clicks -> connection form vyuziva, ja premazavam
                            this.ArrowCreation = false;
                        }
                        break;
                    }
                }
            }
            

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (!ArrowCreation)
            {

                for (int i = this.ContentHolder.Diagrams.Count - 1; i >= 0; i--)
                {
                    this.ContentHolder.Diagrams[i].Selected = false;

                    if (e.X >= this.ContentHolder.Diagrams[i].X && e.X <= this.ContentHolder.Diagrams[i].X + this.ContentHolder.Diagrams[i].Width && e.Y >= this.ContentHolder.Diagrams[i].Y && e.Y <= this.ContentHolder.Diagrams[i].Y + this.ContentHolder.Diagrams[i].Height)
                    {
                        this.ContentHolder.Diagrams[i].Selected = true;
                        break;
                    }
                }
                for (int i = 0; i < this.ContentHolder.Arrows.Count; i++)
                {
                    if (e.X >= this.ContentHolder.Arrows[i].SelectMeX && e.X <= this.ContentHolder.Arrows[i].SelectMeX + this.ContentHolder.Arrows[i].SelectMeDiameter && e.Y >= this.ContentHolder.Arrows[i].SelectMeY && e.Y <= this.ContentHolder.Arrows[i].SelectMeY + this.ContentHolder.Arrows[i].SelectMeDiameter)
                        this.ContentHolder.Arrows[i].IsSelected = true;
                }
            }
            else
            {
                // arrow creation
                for (int i = this.ContentHolder.Diagrams.Count - 1; i >= 0; i--)
                {
                    if (e.X >= this.ContentHolder.Diagrams[i].X && e.X <= this.ContentHolder.Diagrams[i].X + this.ContentHolder.Diagrams[i].Width && e.Y >= this.ContentHolder.Diagrams[i].Y && e.Y <= this.ContentHolder.Diagrams[i].Y + this.ContentHolder.Diagrams[i].Height)
                    {
                        Clicks.Add(new ArrowArgs(e.Location, this.ContentHolder.Diagrams[i]));

                        if (Clicks.Count >= 2)
                        {
                            // create arrow
                            ConnectionForm form = new ConnectionForm(this.Clicks, this.ContentHolder.Arrows);
                            form.ShowDialog();
                            if(form.DialogResult == DialogResult.OK)
                            {
                                Clicks.Clear();
                                this.ArrowCreation = false;
                                break;
                            }
                        }
                    }
                }
            }

            this.pictureBox.Invalidate();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.Selected = null;
            foreach (var item in ContentHolder.Diagrams)
            {
                if (item.Selected)
                {
                    this.Selected = item;
                    break;
                }
            }

            if (this.Selected != null && e.Location.X < this.pictureBox.Width - this.Selected.Width && e.Y < this.pictureBox.Height - this.Selected.Height)
                this.Selected.Move(e.Location);

            this.pictureBox.Invalidate();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Selected != null && e.Location.X < this.pictureBox.Width - this.Selected.Width && e.Y < this.pictureBox.Height - this.Selected.Height)
            {
                this.Selected.X = e.Location.X;
                this.Selected.Y = e.Location.Y;
                this.Selected.Selected = false;
                this.Selected = null;
            }
            this.pictureBox.Invalidate();

        }
        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.Selected is not null)
            {
                this.button_edit_Click(sender, e);
            }

            this.pictureBox.Invalidate();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (this.Selected is not null)
            {
                RemoveForm removeDiagramForm = new RemoveForm(true);
                removeDiagramForm.ShowDialog();
                if(removeDiagramForm.DialogResult == DialogResult.OK)
                {
                    this.ContentHolder.Diagrams.Remove(this.Selected);
                    for (int i = 0; i < this.ContentHolder.Arrows.Count; i++)
                    {
                        if (!this.ContentHolder.Diagrams.Contains(this.ContentHolder.Arrows[i].MyRelations.From) || !this.ContentHolder.Diagrams.Contains(this.ContentHolder.Arrows[i].MyRelations.To))
                        {
                            this.ContentHolder.Arrows.Remove(this.ContentHolder.Arrows[i]);
                        }
                        if (this.ContentHolder.Arrows.Count == 0)
                            break;
                    }
                }
            }
            else
            {
                foreach (var item in this.ContentHolder.Arrows)
                {
                    if (item.IsSelected)
                    {
                        RemoveForm removeDiagramForm = new RemoveForm(false);
                        removeDiagramForm.ShowDialog();
                        if (removeDiagramForm.DialogResult == DialogResult.OK)
                        {
                            this.ContentHolder.Arrows.Remove(item);
                            break;
                        }
                    }
                }
            }
            this.pictureBox.Invalidate();
        }

        private void button_selection_Click(object sender, EventArgs e)
        {
            ArrowCreation = false;
            this.Clicks.Clear();
        }

        private void button_addConection_Click(object sender, EventArgs e)
        {
            //if(this.ContentHolder.Diagrams.Count > 1)
                ArrowCreation = true;
        }

        private void button1_export_Click(object sender, EventArgs e)
        {
            ExportForm exportFortm = new ExportForm();
            exportFortm.ShowDialog();
            if(exportFortm.DialogResult == DialogResult.OK)
            {
                Saver saver = new Saver(exportFortm.FormatTo, exportFortm.PathTo, this.ContentHolder);
                saver.SaveMe();
                MessageBox.Show("Exported!!");
            }

            
        }
        private void button_import_Click(object sender, EventArgs e)
        {
            ImportForm importFortm = new ImportForm();
            importFortm.ShowDialog();
            if(importFortm.DialogResult == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.OpenRead(importFortm.Path))
                {
                    this.ContentHolder = (ContentHolder)formatter.Deserialize(stream);
                }
                foreach (var item in this.ContentHolder.Arrows)
                {
                    if (item.Pen == null)
                    {
                        if (item.GetType() == typeof(Implementation) || item.GetType() == typeof(Dependency))
                        {
                            item.Pen = new Pen(Color.Black, 1);
                            item.Pen.DashStyle = DashStyle.Dash;
                        }
                        else item.Pen = new Pen(Color.Black, 1);
                    }
                }
                pictureBox.Invalidate();
                MessageBox.Show("Imported!!");
            }
        }
    }
}