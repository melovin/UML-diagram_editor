using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UMLdiagrams
{
    public partial class ExportForm : Form
    {
        public string PathTo { get; set; }
        public int FormatTo { get; set; }
        public ExportForm()
        {
            InitializeComponent();
            this.radioButton_image.Checked = true;
        }

        private void button_path_Click(object sender, EventArgs e)
        {
            if (this.radioButton_image.Checked)
            {
                this.saveFileDialog1.Filter = "Data Files (*.jpeg)|*.jpeg";
                this.saveFileDialog1.DefaultExt = "jpeg";

                this.saveFileDialog1.ShowDialog();

                if (this.saveFileDialog1.FileName != "")
                    this.textBox1.Text = this.PathTo = this.saveFileDialog1.FileName;
            }
            else if (this.radioButton_code.Checked)
            {
                this.folderBrowserDialog1.ShowDialog();

                if (this.folderBrowserDialog1.SelectedPath != null)
                    this.textBox1.Text = this.PathTo = this.folderBrowserDialog1.SelectedPath;
            }
            else
            {
                this.saveFileDialog1.Filter = "Data Files (*.dat)|*.dat";
                this.saveFileDialog1.DefaultExt = "dat";
                this.saveFileDialog1.ShowDialog();
                if (this.saveFileDialog1.FileName != "")
                    this.textBox1.Text = this.PathTo = this.saveFileDialog1.FileName;
            }
            this.errorProvider_path.SetError(this.textBox1, null);
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (this.radioButton_image.Checked)
                this.FormatTo = (int)Format.IMAGE;
            else if (this.radioButton_code.Checked)
                this.FormatTo = (int)Format.CODE;
            else
                this.FormatTo = (int)Format.BINARY;

            if (this.textBox1.Text != this.saveFileDialog1.FileName && this.radioButton_image.Checked)
                this.PathTo = this.textBox1.Text;
            else if (this.textBox1.Text != this.folderBrowserDialog1.SelectedPath && this.radioButton_code.Checked)
                this.PathTo = this.textBox1.Text;
            this.textBox1.CausesValidation = true;
            if (PathTo is not null && this.errorProvider_path.GetError(this.textBox1).Length == 0)
            {

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider_path.SetError(this.textBox1, null);
            if(this.textBox1 == null)
                errorProvider_path.SetError(this.textBox1, "Select path !");
            else if (this.FormatTo == (int)Format.CODE)
            {
                if (!Directory.Exists(this.textBox1.Text))
                    errorProvider_path.SetError(this.textBox1, "Select existing path !"); 
            }
            else
            {
                string[] path = this.textBox1.Text.Split('\\');
                string folder = this.textBox1.Text.Substring(0, this.textBox1.Text.Length - path[path.Length - 1].Length);
                if(!Directory.Exists(folder))
                    errorProvider_path.SetError(this.textBox1, "Select existing path !");
            }
        }

        private void radioButton_image_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.CausesValidation = true;
           
        }

        private void radioButton_code_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.CausesValidation = true;
        }

        private void radioButton_json_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.CausesValidation = true;
        }
    }
    public enum Format
    {
        IMAGE,
        CODE,
        BINARY
    }
}
