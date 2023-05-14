namespace UMLdiagrams
{
    partial class OperationInputForm
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
            this.label_nameOfOperation = new System.Windows.Forms.Label();
            this.dataGridView_input = new System.Windows.Forms.DataGridView();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_input)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nameOfOperation
            // 
            this.label_nameOfOperation.AutoSize = true;
            this.label_nameOfOperation.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_nameOfOperation.Location = new System.Drawing.Point(92, 36);
            this.label_nameOfOperation.Name = "label_nameOfOperation";
            this.label_nameOfOperation.Size = new System.Drawing.Size(221, 32);
            this.label_nameOfOperation.TabIndex = 0;
            this.label_nameOfOperation.Text = "Name of operation";
            this.label_nameOfOperation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView_input
            // 
            this.dataGridView_input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_input.Location = new System.Drawing.Point(26, 104);
            this.dataGridView_input.Name = "dataGridView_input";
            this.dataGridView_input.RowTemplate.Height = 25;
            this.dataGridView_input.Size = new System.Drawing.Size(352, 153);
            this.dataGridView_input.TabIndex = 1;
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_ok.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ok.Location = new System.Drawing.Point(64, 352);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(122, 40);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Red;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cancel.Location = new System.Drawing.Point(205, 352);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(122, 40);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Location = new System.Drawing.Point(26, 263);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(75, 23);
            this.button_Remove.TabIndex = 4;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(111, 263);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // OperationInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 404);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.dataGridView_input);
            this.Controls.Add(this.label_nameOfOperation);
            this.Name = "OperationInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperationInputForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_nameOfOperation;
        private DataGridView dataGridView_input;
        private Button button_ok;
        private Button button_cancel;
        private Button button_Remove;
        private Button add_button;
    }
}