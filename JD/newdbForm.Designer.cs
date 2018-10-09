namespace JD
{
    partial class newdbForm
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
            this.OKnewdb_button = new System.Windows.Forms.Button();
            this.Cancelnewdb_button = new System.Windows.Forms.Button();
            this.filename_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKnewdb_button
            // 
            this.OKnewdb_button.Location = new System.Drawing.Point(56, 99);
            this.OKnewdb_button.Name = "OKnewdb_button";
            this.OKnewdb_button.Size = new System.Drawing.Size(75, 23);
            this.OKnewdb_button.TabIndex = 0;
            this.OKnewdb_button.Text = "&Ok";
            this.OKnewdb_button.UseVisualStyleBackColor = true;
            this.OKnewdb_button.Click += new System.EventHandler(this.OKnewdb_button_Click);
            // 
            // Cancelnewdb_button
            // 
            this.Cancelnewdb_button.Location = new System.Drawing.Point(159, 99);
            this.Cancelnewdb_button.Name = "Cancelnewdb_button";
            this.Cancelnewdb_button.Size = new System.Drawing.Size(75, 23);
            this.Cancelnewdb_button.TabIndex = 1;
            this.Cancelnewdb_button.Text = "&Cancel";
            this.Cancelnewdb_button.UseVisualStyleBackColor = true;
            // 
            // filename_textBox
            // 
            this.filename_textBox.Location = new System.Drawing.Point(56, 61);
            this.filename_textBox.Name = "filename_textBox";
            this.filename_textBox.Size = new System.Drawing.Size(178, 20);
            this.filename_textBox.TabIndex = 2;
            this.filename_textBox.Text = "*.db";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter new database filename.";
            // 
            // newdbForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 162);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filename_textBox);
            this.Controls.Add(this.Cancelnewdb_button);
            this.Controls.Add(this.OKnewdb_button);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "newdbForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKnewdb_button;
        private System.Windows.Forms.Button Cancelnewdb_button;
        private System.Windows.Forms.TextBox filename_textBox;
        private System.Windows.Forms.Label label1;
    }
}