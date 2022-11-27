namespace DataDecryptFromJavascriptData
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
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.btnDecrypte = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(12, 12);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(337, 426);
            this.txtData.TabIndex = 0;
            this.txtData.Text = "";
            // 
            // btnDecrypte
            // 
            this.btnDecrypte.Location = new System.Drawing.Point(355, 381);
            this.btnDecrypte.Name = "btnDecrypte";
            this.btnDecrypte.Size = new System.Drawing.Size(250, 57);
            this.btnDecrypte.TabIndex = 1;
            this.btnDecrypte.Text = "Decrypte Data";
            this.btnDecrypte.UseVisualStyleBackColor = true;
            this.btnDecrypte.Click += new System.EventHandler(this.btnDecrypte_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(378, 12);
            this.txtKey.MaxLength = 16;
            this.txtKey.Name = "txtKey";
            this.txtKey.PlaceholderText = "<Your Key>";
            this.txtKey.Size = new System.Drawing.Size(227, 23);
            this.txtKey.TabIndex = 2;
            // 
            // txtIV
            // 
            this.txtIV.Location = new System.Drawing.Point(378, 71);
            this.txtIV.MaxLength = 16;
            this.txtIV.Name = "txtIV";
            this.txtIV.PlaceholderText = "<Your IV>";
            this.txtIV.Size = new System.Drawing.Size(227, 23);
            this.txtIV.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 451);
            this.Controls.Add(this.txtIV);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnDecrypte);
            this.Controls.Add(this.txtData);
            this.MaximumSize = new System.Drawing.Size(664, 490);
            this.MinimumSize = new System.Drawing.Size(664, 490);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Decrypted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txtData;
        private Button btnDecrypte;
        private TextBox txtKey;
        private TextBox txtIV;
    }
}