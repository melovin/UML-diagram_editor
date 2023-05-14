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
using UMLdiagrams.Myclasses;

namespace UMLdiagrams
{
    public partial class OperationInputForm : Form
    {
        public Operation Operation { get; set; }
        public BindingList<Arguments> Arguments { get; set; }

        public OperationInputForm(Operation operation)
        {
            InitializeComponent();
            this.Operation = operation;
            this.label_nameOfOperation.Text = this.Operation.Name;
            //this.label_nameOfOperation.Location = new Point(this.Width / 2  - , this.label_nameOfOperation.Location.Y);

            this.Arguments = new BindingList<Arguments>(operation.MyArguments);
            dataGridView_input.DataSource = Arguments;
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

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView_input.CurrentCell == null)
                return;

            int index = dataGridView_input.CurrentCell.RowIndex;

            if (index < 0) return;

            Arguments.RemoveAt(index);
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Arguments.Add(new Arguments("int", "param"));
        }
    }
}
