using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace UMLdiagrams
{
    public partial class ImportForm : Form
    {
        public string Path { get; set; }
        public ImportForm()
        {
            InitializeComponent();
        }

        private void button_path_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Data Files (*.dat)|*.dat";
            this.openFileDialog1.DefaultExt = "dat";
            this.openFileDialog1.ShowDialog();
            if (this.openFileDialog1.FileName != "")
                this.textBox1.Text = this.Path = this.openFileDialog1.FileName;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            this.textBox1.CausesValidation = true;
            if (Path is not null && ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider1.SetError(this.textBox1, null);
            if (this.textBox1 == null)
                errorProvider1.SetError(this.textBox1, "Select path !");
            else if(!File.Exists(this.textBox1.Text))
                errorProvider1.SetError(this.textBox1, "Select existing path !");
        }
    }
}
