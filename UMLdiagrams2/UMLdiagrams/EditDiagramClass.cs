using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using UMLdiagrams.Myclasses;

namespace UMLdiagrams
{
    public partial class EditDiagramClassForm : Form
    {
        public DiagramClass DiagramClass;
        private int lastOpertationSelection;

        private List<string> OtherNames { get; set; }

        public EditDiagramClassForm(DiagramClass editedClass, List<string> otherNames)
        {
            InitializeComponent();
            this.DiagramClass = editedClass;

            this.dataGridView_operations.DataSource = editedClass.Operations;
            this.dataGridView_properties.DataSource = editedClass.Properties;

            if (this.DiagramClass.Operations.Count != 0 && this.dataGridView_operations.CurrentCell is not null)
                this.dataGridView_inputs.DataSource = this.DiagramClass.Operations[this.dataGridView_operations.CurrentCell.RowIndex].MyArguments;

            OtherNames = otherNames;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (OtherNames.Contains(textBox_name.Text) || this.textBox_name.Text == "" || this.errorProvider_pepa.GetError(this.textBox_name).Length >0)
                return;

            string typeOfClass = "";
            if (radioButton_abstract.Checked)
                typeOfClass = "abstract class";
            else if (radioButton_interface.Checked)
                typeOfClass = "interface";
            else if (radioButton_class.Checked)
                typeOfClass = "class";

            string isChecked = "";
            if (radioButton_private.Checked)
                isChecked = "-";
            else if (radioButton_protected.Checked)
                isChecked = "#";
            else if (radioButton_public.Checked)
                isChecked = "+";

            this.DiagramClass.Name = this.textBox_name.Text;
            this.DiagramClass.TypeOfClass = typeOfClass;
            this.DiagramClass.Access = isChecked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_addInput_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_operations.CurrentCell is not null)
            {
                Operation toEdit = this.DiagramClass.Operations[lastOpertationSelection];

                OperationInputForm inputForm = new OperationInputForm(toEdit);
                inputForm.ShowDialog();
                if (inputForm.DialogResult == DialogResult.OK)
                {
                    this.dataGridView_inputs.DataSource = inputForm.Arguments;
                    toEdit.MyArguments = inputForm.Arguments;
                }

            }
            else
                MessageBox.Show("Select operation!");
        }


        private void dataGridView_operations_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView_operations.CurrentCell == null) 
                return;

            this.lastOpertationSelection = dataGridView_operations.CurrentCell.RowIndex;

            if (this.dataGridView_operations.CurrentCell.RowIndex >= this.DiagramClass.Operations.Count)
            {
                this.dataGridView_inputs.DataSource = null;
                return;
            }

            if (this.DiagramClass.Operations.Count != 0)
            {
                this.dataGridView_inputs.DataSource = null;
                this.dataGridView_inputs.DataSource = this.DiagramClass.Operations[this.dataGridView_operations.CurrentCell.RowIndex].MyArguments;
            }
        }

        private void button_removeProp_Click(object sender, EventArgs e)
        {
            if (dataGridView_properties.CurrentCell == null)
                return;

            int index = dataGridView_properties.CurrentCell.RowIndex;

            if (index < 0)
                return;

            this.DiagramClass.Properties.RemoveAt(index);

        }

        private void button_AddProp_Click(object sender, EventArgs e)
        {
            this.DiagramClass.Properties.Add(new Property("+", "int", "index"));
        }

        private void button_removeOp_Click(object sender, EventArgs e)
        {
            if (dataGridView_operations.CurrentCell == null)
                return;

            int index = dataGridView_operations.CurrentCell.RowIndex;

            if (index < 0)
                return;

            this.DiagramClass.Operations.RemoveAt(index);
        }

        private void button_addOp_Click(object sender, EventArgs e)
        {
            this.DiagramClass.Operations.Add(new Operation("+", "void", "GetAge"));
        }

        private void button_removeImput_Click(object sender, EventArgs e)
        {
            if (this.dataGridView_inputs.Rows.Count > 0)
                this.DiagramClass.Operations[this.dataGridView_operations.CurrentCell.RowIndex].MyArguments.RemoveAt(this.dataGridView_inputs.CurrentCell.RowIndex);
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            errorProvider_pepa.SetError(textBox_name, null);

            if (OtherNames.Contains(textBox_name.Text))
            {
                errorProvider_pepa.SetError(textBox_name, "Name must be unique :D !");
            }
            else if(this.textBox_name.Text == "")
                errorProvider_pepa.SetError(textBox_name, "Name can't be empty!");
            else if (Regex.IsMatch(this.textBox_name.Text, @"^\d{1}"))
                errorProvider_pepa.SetError(textBox_name, "Name can't start with number!");
        }

        private void radioButton_interface_Click(object sender, EventArgs e)
        {
            this.radioButton_private.Enabled = false;
            this.radioButton_protected.Enabled = false;
            this.radioButton_public.Checked = true;
        }

        private void radioButton_class_Click(object sender, EventArgs e)
        {
            this.radioButton_private.Enabled = true;
            this.radioButton_protected.Enabled = true;
        }

        private void radioButton_abstract_Click(object sender, EventArgs e)
        {
            this.radioButton_private.Enabled = false;
            this.radioButton_protected.Enabled = false;
            this.radioButton_public.Checked = true;
        }
    }
}
