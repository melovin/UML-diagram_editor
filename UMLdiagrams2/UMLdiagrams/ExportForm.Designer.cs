namespace UMLdiagrams
{
    partial class ExportForm
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
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_image = new System.Windows.Forms.RadioButton();
            this.radioButton_json = new System.Windows.Forms.RadioButton();
            this.radioButton_code = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_path = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider_path = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_path)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ok.Location = new System.Drawing.Point(237, 175);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 35);
            this.button_ok.TabIndex = 0;
            this.button_ok.Text = "Ok";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Red;
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cancel.Location = new System.Drawing.Point(422, 175);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(100, 35);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Export";
            // 
            // radioButton_image
            // 
            this.radioButton_image.AutoSize = true;
            this.radioButton_image.Location = new System.Drawing.Point(47, 109);
            this.radioButton_image.Name = "radioButton_image";
            this.radioButton_image.Size = new System.Drawing.Size(58, 19);
            this.radioButton_image.TabIndex = 3;
            this.radioButton_image.TabStop = true;
            this.radioButton_image.Text = "Image";
            this.radioButton_image.UseVisualStyleBackColor = true;
            this.radioButton_image.CheckedChanged += new System.EventHandler(this.radioButton_image_CheckedChanged);
            // 
            // radioButton_json
            // 
            this.radioButton_json.AutoSize = true;
            this.radioButton_json.Location = new System.Drawing.Point(218, 108);
            this.radioButton_json.Name = "radioButton_json";
            this.radioButton_json.Size = new System.Drawing.Size(58, 19);
            this.radioButton_json.TabIndex = 4;
            this.radioButton_json.TabStop = true;
            this.radioButton_json.Text = "Binary";
            this.radioButton_json.UseVisualStyleBackColor = true;
            this.radioButton_json.CheckedChanged += new System.EventHandler(this.radioButton_json_CheckedChanged);
            // 
            // radioButton_code
            // 
            this.radioButton_code.AutoSize = true;
            this.radioButton_code.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton_code.Location = new System.Drawing.Point(141, 109);
            this.radioButton_code.Name = "radioButton_code";
            this.radioButton_code.Size = new System.Drawing.Size(53, 19);
            this.radioButton_code.TabIndex = 5;
            this.radioButton_code.TabStop = true;
            this.radioButton_code.Text = "Code";
            this.radioButton_code.UseVisualStyleBackColor = true;
            this.radioButton_code.CheckedChanged += new System.EventHandler(this.radioButton_code_CheckedChanged);
            // 
            // button_path
            // 
            this.button_path.Location = new System.Drawing.Point(661, 109);
            this.button_path.Name = "button_path";
            this.button_path.Size = new System.Drawing.Size(75, 23);
            this.button_path.TabIndex = 6;
            this.button_path.Text = "Path";
            this.button_path.UseVisualStyleBackColor = true;
            this.button_path.Click += new System.EventHandler(this.button_path_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // errorProvider_path
            // 
            this.errorProvider_path.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider_path.ContainerControl = this;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 273);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_path);
            this.Controls.Add(this.radioButton_code);
            this.Controls.Add(this.radioButton_json);
            this.Controls.Add(this.radioButton_image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_path)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_ok;
        private Button button_cancel;
        private Label label1;
        private RadioButton radioButton_image;
        private RadioButton radioButton_json;
        private RadioButton radioButton_code;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button_path;
        private TextBox textBox1;
        private SaveFileDialog saveFileDialog1;
        private ErrorProvider errorProvider_path;
    }
}