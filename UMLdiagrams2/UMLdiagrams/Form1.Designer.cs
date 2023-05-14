namespace UMLdiagrams
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1_export = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_selection = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_addConection = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_addClass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(237, 56);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(967, 553);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // button1_export
            // 
            this.button1_export.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1_export.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_export.Location = new System.Drawing.Point(1096, 12);
            this.button1_export.Name = "button1_export";
            this.button1_export.Size = new System.Drawing.Size(108, 34);
            this.button1_export.TabIndex = 1;
            this.button1_export.Text = "Export >";
            this.button1_export.UseVisualStyleBackColor = false;
            this.button1_export.Click += new System.EventHandler(this.button1_export_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button_selection);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_addConection);
            this.panel1.Controls.Add(this.button_remove);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_addClass);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 553);
            this.panel1.TabIndex = 2;
            // 
            // button_selection
            // 
            this.button_selection.Location = new System.Drawing.Point(45, 287);
            this.button_selection.Name = "button_selection";
            this.button_selection.Size = new System.Drawing.Size(112, 37);
            this.button_selection.TabIndex = 10;
            this.button_selection.Text = "Select";
            this.button_selection.UseVisualStyleBackColor = true;
            this.button_selection.Click += new System.EventHandler(this.button_selection_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(45, 419);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(112, 37);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_addConection
            // 
            this.button_addConection.Location = new System.Drawing.Point(45, 244);
            this.button_addConection.Name = "button_addConection";
            this.button_addConection.Size = new System.Drawing.Size(112, 37);
            this.button_addConection.TabIndex = 7;
            this.button_addConection.Text = "Add conection";
            this.button_addConection.UseVisualStyleBackColor = true;
            this.button_addConection.Click += new System.EventHandler(this.button_addConection_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(45, 472);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(112, 37);
            this.button_remove.TabIndex = 6;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(34, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Components";
            // 
            // button_addClass
            // 
            this.button_addClass.Location = new System.Drawing.Point(45, 176);
            this.button_addClass.Name = "button_addClass";
            this.button_addClass.Size = new System.Drawing.Size(112, 37);
            this.button_addClass.TabIndex = 0;
            this.button_addClass.Text = "Add class";
            this.button_addClass.UseVisualStyleBackColor = true;
            this.button_addClass.Click += new System.EventHandler(this.button_addClass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(517, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "UML Diagrams";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(12, 12);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(102, 34);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(965, 12);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(112, 34);
            this.button_import.TabIndex = 11;
            this.button_import.Text = "Import";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 645);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1_export);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private Button button1_export;
        private PrintDialog printDialog1;
        private Panel panel1;
        private Button button_addClass;
        private Label label1;
        private Button button_clear;
        private Button button_remove;
        private Label label2;
        private Button button_addConection;
        private Button button_edit;
        private Button button_import;
        private Button button_selection;
    }
}