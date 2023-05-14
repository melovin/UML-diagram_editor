namespace UMLdiagrams
{
    partial class EditDiagramClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton_class = new System.Windows.Forms.RadioButton();
            this.radioButton_abstract = new System.Windows.Forms.RadioButton();
            this.radioButton_interface = new System.Windows.Forms.RadioButton();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.dataGridView_properties = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_operations = new System.Windows.Forms.DataGridView();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.radioButton_protected = new System.Windows.Forms.RadioButton();
            this.radioButton_public = new System.Windows.Forms.RadioButton();
            this.radioButton_private = new System.Windows.Forms.RadioButton();
            this.groupBox_class = new System.Windows.Forms.GroupBox();
            this.groupBox1_access = new System.Windows.Forms.GroupBox();
            this.button_addInput = new System.Windows.Forms.Button();
            this.dataGridView_inputs = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button_removeInput = new System.Windows.Forms.Button();
            this.button_removeProp = new System.Windows.Forms.Button();
            this.button_removeOp = new System.Windows.Forms.Button();
            this.button_addOp = new System.Windows.Forms.Button();
            this.button_AddProp = new System.Windows.Forms.Button();
            this.errorProvider_pepa = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operations)).BeginInit();
            this.groupBox_class.SuspendLayout();
            this.groupBox1_access.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pepa)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(532, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Diagram";
            // 
            // radioButton_class
            // 
            this.radioButton_class.AutoSize = true;
            this.radioButton_class.Checked = true;
            this.radioButton_class.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_class.Location = new System.Drawing.Point(6, 46);
            this.radioButton_class.Name = "radioButton_class";
            this.radioButton_class.Size = new System.Drawing.Size(56, 21);
            this.radioButton_class.TabIndex = 2;
            this.radioButton_class.TabStop = true;
            this.radioButton_class.Text = "Class";
            this.radioButton_class.UseVisualStyleBackColor = true;
            this.radioButton_class.Click += new System.EventHandler(this.radioButton_class_Click);
            // 
            // radioButton_abstract
            // 
            this.radioButton_abstract.AutoSize = true;
            this.radioButton_abstract.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_abstract.Location = new System.Drawing.Point(195, 46);
            this.radioButton_abstract.Name = "radioButton_abstract";
            this.radioButton_abstract.Size = new System.Drawing.Size(109, 21);
            this.radioButton_abstract.TabIndex = 3;
            this.radioButton_abstract.Text = "Abstract class";
            this.radioButton_abstract.UseVisualStyleBackColor = true;
            this.radioButton_abstract.Click += new System.EventHandler(this.radioButton_abstract_Click);
            // 
            // radioButton_interface
            // 
            this.radioButton_interface.AutoSize = true;
            this.radioButton_interface.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_interface.Location = new System.Drawing.Point(93, 46);
            this.radioButton_interface.Name = "radioButton_interface";
            this.radioButton_interface.Size = new System.Drawing.Size(79, 21);
            this.radioButton_interface.TabIndex = 4;
            this.radioButton_interface.Text = "Interface";
            this.radioButton_interface.UseVisualStyleBackColor = true;
            this.radioButton_interface.Click += new System.EventHandler(this.radioButton_interface_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(445, 80);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(296, 23);
            this.textBox_name.TabIndex = 5;
            this.textBox_name.Text = "Class";
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_name_Validating);
            // 
            // dataGridView_properties
            // 
            this.dataGridView_properties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_properties.Location = new System.Drawing.Point(54, 288);
            this.dataGridView_properties.Name = "dataGridView_properties";
            this.dataGridView_properties.RowTemplate.Height = 25;
            this.dataGridView_properties.Size = new System.Drawing.Size(369, 121);
            this.dataGridView_properties.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(445, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(456, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Operations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Properties";
            // 
            // dataGridView_operations
            // 
            this.dataGridView_operations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_operations.Location = new System.Drawing.Point(456, 288);
            this.dataGridView_operations.Name = "dataGridView_operations";
            this.dataGridView_operations.RowTemplate.Height = 25;
            this.dataGridView_operations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_operations.Size = new System.Drawing.Size(369, 121);
            this.dataGridView_operations.TabIndex = 11;
            this.dataGridView_operations.SelectionChanged += new System.EventHandler(this.dataGridView_operations_SelectionChanged);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_ok.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ok.Location = new System.Drawing.Point(419, 484);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(127, 48);
            this.button_ok.TabIndex = 12;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Red;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cancel.Location = new System.Drawing.Point(643, 484);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(127, 48);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // radioButton_protected
            // 
            this.radioButton_protected.AutoSize = true;
            this.radioButton_protected.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_protected.Location = new System.Drawing.Point(254, 39);
            this.radioButton_protected.Name = "radioButton_protected";
            this.radioButton_protected.Size = new System.Drawing.Size(85, 21);
            this.radioButton_protected.TabIndex = 16;
            this.radioButton_protected.Text = "Protected";
            this.radioButton_protected.UseVisualStyleBackColor = true;
            // 
            // radioButton_public
            // 
            this.radioButton_public.AutoSize = true;
            this.radioButton_public.Checked = true;
            this.radioButton_public.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_public.Location = new System.Drawing.Point(35, 39);
            this.radioButton_public.Name = "radioButton_public";
            this.radioButton_public.Size = new System.Drawing.Size(62, 21);
            this.radioButton_public.TabIndex = 14;
            this.radioButton_public.TabStop = true;
            this.radioButton_public.Text = "Public";
            this.radioButton_public.UseVisualStyleBackColor = true;
            // 
            // radioButton_private
            // 
            this.radioButton_private.AutoSize = true;
            this.radioButton_private.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButton_private.Location = new System.Drawing.Point(145, 39);
            this.radioButton_private.Name = "radioButton_private";
            this.radioButton_private.Size = new System.Drawing.Size(68, 21);
            this.radioButton_private.TabIndex = 17;
            this.radioButton_private.Text = "Private";
            this.radioButton_private.UseVisualStyleBackColor = true;
            // 
            // groupBox_class
            // 
            this.groupBox_class.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_class.Controls.Add(this.radioButton_class);
            this.groupBox_class.Controls.Add(this.radioButton_abstract);
            this.groupBox_class.Controls.Add(this.radioButton_interface);
            this.groupBox_class.Location = new System.Drawing.Point(146, 132);
            this.groupBox_class.Name = "groupBox_class";
            this.groupBox_class.Size = new System.Drawing.Size(369, 100);
            this.groupBox_class.TabIndex = 18;
            this.groupBox_class.TabStop = false;
            this.groupBox_class.Text = "Class";
            // 
            // groupBox1_access
            // 
            this.groupBox1_access.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1_access.Controls.Add(this.radioButton_public);
            this.groupBox1_access.Controls.Add(this.radioButton_private);
            this.groupBox1_access.Controls.Add(this.radioButton_protected);
            this.groupBox1_access.Location = new System.Drawing.Point(673, 132);
            this.groupBox1_access.Name = "groupBox1_access";
            this.groupBox1_access.Size = new System.Drawing.Size(374, 100);
            this.groupBox1_access.TabIndex = 19;
            this.groupBox1_access.TabStop = false;
            this.groupBox1_access.Text = "Access";
            // 
            // button_addInput
            // 
            this.button_addInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_addInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addInput.Location = new System.Drawing.Point(972, 415);
            this.button_addInput.Name = "button_addInput";
            this.button_addInput.Size = new System.Drawing.Size(75, 32);
            this.button_addInput.TabIndex = 20;
            this.button_addInput.Text = "Add input";
            this.button_addInput.UseVisualStyleBackColor = false;
            this.button_addInput.Click += new System.EventHandler(this.button_addInput_Click);
            // 
            // dataGridView_inputs
            // 
            this.dataGridView_inputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_inputs.Location = new System.Drawing.Point(860, 288);
            this.dataGridView_inputs.Name = "dataGridView_inputs";
            this.dataGridView_inputs.RowTemplate.Height = 25;
            this.dataGridView_inputs.Size = new System.Drawing.Size(271, 121);
            this.dataGridView_inputs.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(860, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Inputs";
            // 
            // button_removeInput
            // 
            this.button_removeInput.BackColor = System.Drawing.Color.Red;
            this.button_removeInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_removeInput.Location = new System.Drawing.Point(1056, 415);
            this.button_removeInput.Name = "button_removeInput";
            this.button_removeInput.Size = new System.Drawing.Size(75, 32);
            this.button_removeInput.TabIndex = 23;
            this.button_removeInput.Text = "Remove";
            this.button_removeInput.UseVisualStyleBackColor = false;
            this.button_removeInput.Click += new System.EventHandler(this.button_removeImput_Click);
            // 
            // button_removeProp
            // 
            this.button_removeProp.BackColor = System.Drawing.Color.Red;
            this.button_removeProp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_removeProp.Location = new System.Drawing.Point(348, 415);
            this.button_removeProp.Name = "button_removeProp";
            this.button_removeProp.Size = new System.Drawing.Size(75, 32);
            this.button_removeProp.TabIndex = 24;
            this.button_removeProp.Text = "Remove";
            this.button_removeProp.UseVisualStyleBackColor = false;
            this.button_removeProp.Click += new System.EventHandler(this.button_removeProp_Click);
            // 
            // button_removeOp
            // 
            this.button_removeOp.BackColor = System.Drawing.Color.Red;
            this.button_removeOp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_removeOp.Location = new System.Drawing.Point(750, 415);
            this.button_removeOp.Name = "button_removeOp";
            this.button_removeOp.Size = new System.Drawing.Size(75, 32);
            this.button_removeOp.TabIndex = 25;
            this.button_removeOp.Text = "Remove";
            this.button_removeOp.UseVisualStyleBackColor = false;
            this.button_removeOp.Click += new System.EventHandler(this.button_removeOp_Click);
            // 
            // button_addOp
            // 
            this.button_addOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_addOp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addOp.Location = new System.Drawing.Point(673, 415);
            this.button_addOp.Name = "button_addOp";
            this.button_addOp.Size = new System.Drawing.Size(75, 32);
            this.button_addOp.TabIndex = 26;
            this.button_addOp.Text = "Add";
            this.button_addOp.UseVisualStyleBackColor = false;
            this.button_addOp.Click += new System.EventHandler(this.button_addOp_Click);
            // 
            // button_AddProp
            // 
            this.button_AddProp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AddProp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_AddProp.Location = new System.Drawing.Point(267, 415);
            this.button_AddProp.Name = "button_AddProp";
            this.button_AddProp.Size = new System.Drawing.Size(75, 32);
            this.button_AddProp.TabIndex = 27;
            this.button_AddProp.Text = "Add";
            this.button_AddProp.UseVisualStyleBackColor = false;
            this.button_AddProp.Click += new System.EventHandler(this.button_AddProp_Click);
            // 
            // errorProvider_pepa
            // 
            this.errorProvider_pepa.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_pepa.ContainerControl = this;
            // 
            // EditDiagramClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 544);
            this.Controls.Add(this.button_AddProp);
            this.Controls.Add(this.button_addOp);
            this.Controls.Add(this.button_removeOp);
            this.Controls.Add(this.button_removeProp);
            this.Controls.Add(this.button_removeInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_inputs);
            this.Controls.Add(this.button_addInput);
            this.Controls.Add(this.groupBox1_access);
            this.Controls.Add(this.groupBox_class);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.dataGridView_operations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_properties);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label2);
            this.Name = "EditDiagramClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditDiagramClass";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_operations)).EndInit();
            this.groupBox_class.ResumeLayout(false);
            this.groupBox_class.PerformLayout();
            this.groupBox1_access.ResumeLayout(false);
            this.groupBox1_access.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_inputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pepa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private RadioButton radioButton_class;
        private RadioButton radioButton_abstract;
        private RadioButton radioButton_interface;
        private TextBox textBox_name;
        private DataGridView dataGridView_properties;
        private Label label1;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView_operations;
        private Button button_ok;
        private Button button_cancel;
        private RadioButton radioButton_protected;
        private RadioButton radioButton_public;
        private RadioButton radioButton_private;
        private GroupBox groupBox_class;
        private GroupBox groupBox1_access;
        private Button button_addInput;
        private DataGridView dataGridView_inputs;
        private Label label5;
        private Button button_removeInput;
        private Button button_removeProp;
        private Button button_removeOp;
        private Button button_addOp;
        private Button button_AddProp;
        private ErrorProvider errorProvider_pepa;
    }
}