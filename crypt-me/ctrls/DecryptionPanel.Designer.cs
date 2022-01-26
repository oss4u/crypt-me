
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
            this.controlPanel1 = new CryptMe.ctrls.ControlPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chooseFileToDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.b64Intermediate = new System.Windows.Forms.TextBox();
            this.cbDecodeB64 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.fileToDecrypt = new System.Windows.Forms.TextBox();
            this.openFileForDecryptionDialog = new System.Windows.Forms.OpenFileDialog();
            this.decryptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // decryptGroup
            // 
            this.decryptGroup.Controls.Add(this.controlPanel1);
            this.decryptGroup.Controls.Add(this.label1);
            this.decryptGroup.Controls.Add(this.txtPasswordConfirm);
            this.decryptGroup.Controls.Add(this.txtPassword);
            this.decryptGroup.Controls.Add(this.chooseFileToDecrypt);
            this.decryptGroup.Controls.Add(this.label4);
            this.decryptGroup.Controls.Add(this.b64Intermediate);
            this.decryptGroup.Controls.Add(this.cbDecodeB64);
            this.decryptGroup.Controls.Add(this.label5);
            this.decryptGroup.Controls.Add(this.fileNameLbl);
            this.decryptGroup.Controls.Add(this.txtFilename);
            this.decryptGroup.Controls.Add(this.fileToDecrypt);
            this.decryptGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decryptGroup.Location = new System.Drawing.Point(0, 0);
            this.decryptGroup.Name = "decryptGroup";
            this.decryptGroup.Size = new System.Drawing.Size(900, 502);
            this.decryptGroup.TabIndex = 9;
            this.decryptGroup.TabStop = false;
            this.decryptGroup.Text = "Datei Entschlüsseln";
            // 
            // controlPanel1
            // 
            this.controlPanel1.CloseBtnEnabled = true;
            this.controlPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel1.Location = new System.Drawing.Point(3, 445);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.OkBtnEnabled = false;
            this.controlPanel1.Size = new System.Drawing.Size(894, 54);
            this.controlPanel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Passwort:";
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(144, 161);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(296, 20);
            this.txtPasswordConfirm.TabIndex = 9;
            this.txtPasswordConfirm.TextChanged += new System.EventHandler(this.changeCheck);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(296, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.changeCheck);
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
            this.chooseFileToDecrypt.Click += new System.EventHandler(this.chooseFileToDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dateiname:";
            // 
            // b64Intermediate
            // 
            this.b64Intermediate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b64Intermediate.Location = new System.Drawing.Point(144, 52);
            this.b64Intermediate.Name = "b64Intermediate";
            this.b64Intermediate.Size = new System.Drawing.Size(750, 20);
            this.b64Intermediate.TabIndex = 5;
            this.b64Intermediate.TextChanged += new System.EventHandler(this.changeCheck);
            // 
            // cbDecodeB64
            // 
            this.cbDecodeB64.AutoSize = true;
            this.cbDecodeB64.Checked = true;
            this.cbDecodeB64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDecodeB64.Location = new System.Drawing.Point(144, 75);
            this.cbDecodeB64.Name = "cbDecodeB64";
            this.cbDecodeB64.Size = new System.Drawing.Size(193, 17);
            this.cbDecodeB64.TabIndex = 4;
            this.cbDecodeB64.Text = "Datei soll Base64 dekodiert werden";
            this.cbDecodeB64.UseVisualStyleBackColor = true;
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
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Location = new System.Drawing.Point(144, 98);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(750, 20);
            this.txtFilename.TabIndex = 1;
            this.txtFilename.TextChanged += new System.EventHandler(this.changeCheck);
            // 
            // fileToDecrypt
            // 
            this.fileToDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileToDecrypt.Location = new System.Drawing.Point(144, 22);
            this.fileToDecrypt.Name = "fileToDecrypt";
            this.fileToDecrypt.Size = new System.Drawing.Size(647, 20);
            this.fileToDecrypt.TabIndex = 0;
            this.fileToDecrypt.TextChanged += new System.EventHandler(this.changeCheck);
            // 
            // openFileForDecryptionDialog
            // 
            this.openFileForDecryptionDialog.Filter = "Verschlüsselte Dateien (*.b64;*.aes)|*.b64;*.aes|Alle Dateien (*.*)|*.*";
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
        private System.Windows.Forms.TextBox b64Intermediate;
        private System.Windows.Forms.CheckBox cbDecodeB64;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label fileNameLbl;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.TextBox fileToDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.OpenFileDialog openFileForDecryptionDialog;
        private ControlPanel controlPanel1;
    }
}
