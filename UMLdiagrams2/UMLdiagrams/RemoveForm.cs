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
    public partial class RemoveForm : Form
    {
        public RemoveForm(bool diagramSelected)
        {
            InitializeComponent();
            if (diagramSelected)
            {
                this.label_changeMe.Location = new Point(this.label_changeMe.Location.X - 75,this.label_changeMe.Location.Y);
                this.label_changeMe.Text = "Are you sure you want to remove diagram and it's connections?";
            }

            else
                this.label_changeMe.Text = "Are you sure you want to remove arrow?";
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
