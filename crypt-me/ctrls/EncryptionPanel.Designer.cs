
namespace CryptMe.ctrls
{
    partial class EncryptionPanel
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
            this.openFileForEncryptionDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtFilenameEnc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptGroup = new System.Windows.Forms.GroupBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.encryptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(144, 22);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(533, 20);
            this.txtFilename.TabIndex = 0;
            this.txtFilename.TextChanged += new System.EventHandler(this.changeCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dateiname:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(144, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Datei soll Base64 kodiert werden";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtFilenameEnc
            // 
            this.txtFilenameEnc.Location = new System.Drawing.Point(144, 71);
            this.txtFilenameEnc.Name = "txtFilenameEnc";
            this.txtFilenameEnc.Size = new System.Drawing.Size(613, 20);
            this.txtFilenameEnc.TabIndex = 5;
            this.txtFilenameEnc.TextChanged += new System.EventHandler(this.changeCheck);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dateiname (Verschlüsselt):";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Datei";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 97);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(296, 20);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextChanged += new System.EventHandler(this.changeCheck);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(144, 123);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(296, 20);
            this.txtPasswordConfirm.TabIndex = 12;
            this.txtPasswordConfirm.TextChanged += new System.EventHandler(this.changeCheck);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Passwort:";
            // 
            // encryptGroup
            // 
            this.encryptGroup.Controls.Add(this.btnEncrypt);
            this.encryptGroup.Controls.Add(this.label4);
            this.encryptGroup.Controls.Add(this.txtPasswordConfirm);
            this.encryptGroup.Controls.Add(this.txtPassword);
            this.encryptGroup.Controls.Add(this.button2);
            this.encryptGroup.Controls.Add(this.label3);
            this.encryptGroup.Controls.Add(this.txtFilenameEnc);
            this.encryptGroup.Controls.Add(this.checkBox1);
            this.encryptGroup.Controls.Add(this.label1);
            this.encryptGroup.Controls.Add(this.txtFilename);
            this.encryptGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptGroup.Location = new System.Drawing.Point(0, 0);
            this.encryptGroup.Name = "encryptGroup";
            this.encryptGroup.Size = new System.Drawing.Size(963, 619);
            this.encryptGroup.TabIndex = 4;
            this.encryptGroup.TabStop = false;
            this.encryptGroup.Text = "Datei Verschlüsseln";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(144, 149);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(85, 23);
            this.btnEncrypt.TabIndex = 14;
            this.btnEncrypt.Text = "Verschlüsseln";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // EncryptionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.encryptGroup);
            this.Name = "EncryptionPanel";
            this.Size = new System.Drawing.Size(963, 619);
            this.encryptGroup.ResumeLayout(false);
            this.encryptGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileForEncryptionDialog;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtFilenameEnc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox encryptGroup;
        private System.Windows.Forms.Button btnEncrypt;
    }
}
