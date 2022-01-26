
namespace CryptMe.ctrls
{
    partial class DecryptionPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.decryptGroup = new System.Windows.Forms.GroupBox();
            this.chooseFileToDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.fileToDecrypt = new System.Windows.Forms.TextBox();
            this.decryptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // decryptGroup
            // 
            this.decryptGroup.Controls.Add(this.chooseFileToDecrypt);
            this.decryptGroup.Controls.Add(this.label4);
            this.decryptGroup.Controls.Add(this.textBox4);
            this.decryptGroup.Controls.Add(this.checkBox2);
            this.decryptGroup.Controls.Add(this.label5);
            this.decryptGroup.Controls.Add(this.fileNameLbl);
            this.decryptGroup.Controls.Add(this.textBox5);
            this.decryptGroup.Controls.Add(this.fileToDecrypt);
            this.decryptGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptGroup.Location = new System.Drawing.Point(0, 0);
            this.decryptGroup.Name = "decryptGroup";
            this.decryptGroup.Size = new System.Drawing.Size(900, 502);
            this.decryptGroup.TabIndex = 9;
            this.decryptGroup.TabStop = false;
            this.decryptGroup.Text = "Datei Entschlüsseln";
            this.decryptGroup.Visible = false;
            // 
            // chooseFileToDecrypt
            // 
            this.chooseFileToDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFileToDecrypt.Location = new System.Drawing.Point(797, 20);
            this.chooseFileToDecrypt.Name = "chooseFileToDecrypt";
            this.chooseFileToDecrypt.Size = new System.Drawing.Size(97, 23);
            this.chooseFileToDecrypt.TabIndex = 7;
            this.chooseFileToDecrypt.Text = "Datei";
            this.chooseFileToDecrypt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dateiname (Verschlüsselt):";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(144, 52);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(750, 20);
            this.textBox4.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(144, 75);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(181, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Datei soll Base64 kodiert werden";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dateiname (Verschlüsselt):";
            // 
            // fileNameLbl
            // 
            this.fileNameLbl.AutoSize = true;
            this.fileNameLbl.Location = new System.Drawing.Point(6, 101);
            this.fileNameLbl.Name = "fileNameLbl";
            this.fileNameLbl.Size = new System.Drawing.Size(61, 13);
            this.fileNameLbl.TabIndex = 2;
            this.fileNameLbl.Text = "Dateiname:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(144, 98);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(750, 20);
            this.textBox5.TabIndex = 1;
            // 
            // fileToDecrypt
            // 
            this.fileToDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileToDecrypt.Location = new System.Drawing.Point(144, 22);
            this.fileToDecrypt.Name = "fileToDecrypt";
            this.fileToDecrypt.Size = new System.Drawing.Size(647, 20);
            this.fileToDecrypt.TabIndex = 0;
            // 
            // DecryptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.decryptGroup);
            this.Name = "DecryptionPanel";
            this.Size = new System.Drawing.Size(900, 502);
            this.decryptGroup.ResumeLayout(false);
            this.decryptGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox decryptGroup;
        private System.Windows.Forms.Button chooseFileToDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox fileToDecrypt;
    }
}
