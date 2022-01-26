
namespace CryptMe
{
    partial class MainForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.startEncryption = new System.Windows.Forms.Button();
            this.openFileForEncryptionDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileForDecryptionDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zumVerschlüsselnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zumEntschlüsselnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.decryptGroup = new System.Windows.Forms.GroupBox();
            this.chooseFileToDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fileNameLbl = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.fileToDecrypt = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.encryptGroup.SuspendLayout();
            this.decryptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // startEncryption
            // 
            this.startEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startEncryption.Location = new System.Drawing.Point(663, 408);
            this.startEncryption.Name = "startEncryption";
            this.startEncryption.Size = new System.Drawing.Size(112, 30);
            this.startEncryption.TabIndex = 0;
            this.startEncryption.Text = "Verschlüsseln";
            this.startEncryption.UseVisualStyleBackColor = true;
            this.startEncryption.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // openFileForEncryptionDialog
            // 
            this.openFileForEncryptionDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(545, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Entschlüsseln";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiÖffnenToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // dateiÖffnenToolStripMenuItem
            // 
            this.dateiÖffnenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zumVerschlüsselnToolStripMenuItem,
            this.zumEntschlüsselnToolStripMenuItem});
            this.dateiÖffnenToolStripMenuItem.Name = "dateiÖffnenToolStripMenuItem";
            this.dateiÖffnenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateiÖffnenToolStripMenuItem.Text = "Datei öffnen...";
            // 
            // zumVerschlüsselnToolStripMenuItem
            // 
            this.zumVerschlüsselnToolStripMenuItem.Name = "zumVerschlüsselnToolStripMenuItem";
            this.zumVerschlüsselnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zumVerschlüsselnToolStripMenuItem.Text = "...zum Verschlüsseln";
            this.zumVerschlüsselnToolStripMenuItem.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // zumEntschlüsselnToolStripMenuItem
            // 
            this.zumEntschlüsselnToolStripMenuItem.Name = "zumEntschlüsselnToolStripMenuItem";
            this.zumEntschlüsselnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zumEntschlüsselnToolStripMenuItem.Text = "...zum Entschlüsseln";
            this.zumEntschlüsselnToolStripMenuItem.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // encryptGroup
            // 
            this.encryptGroup.Controls.Add(this.button2);
            this.encryptGroup.Controls.Add(this.label3);
            this.encryptGroup.Controls.Add(this.textBox3);
            this.encryptGroup.Controls.Add(this.checkBox1);
            this.encryptGroup.Controls.Add(this.label2);
            this.encryptGroup.Controls.Add(this.label1);
            this.encryptGroup.Controls.Add(this.textBox2);
            this.encryptGroup.Controls.Add(this.textBox1);
            this.encryptGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.encryptGroup.Enabled = false;
            this.encryptGroup.Location = new System.Drawing.Point(0, 24);
            this.encryptGroup.Name = "encryptGroup";
            this.encryptGroup.Size = new System.Drawing.Size(785, 423);
            this.encryptGroup.TabIndex = 3;
            this.encryptGroup.TabStop = false;
            this.encryptGroup.Text = "Datei Verschlüsseln";
            this.encryptGroup.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dateiname (Verschlüsselt):";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 98);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(613, 20);
            this.textBox3.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(144, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Datei soll Base64 kodiert werden";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dateiname (Verschlüsselt):";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(613, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 20);
            this.textBox1.TabIndex = 0;
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
            this.decryptGroup.Location = new System.Drawing.Point(0, 24);
            this.decryptGroup.Name = "decryptGroup";
            this.decryptGroup.Size = new System.Drawing.Size(785, 423);
            this.decryptGroup.TabIndex = 8;
            this.decryptGroup.TabStop = false;
            this.decryptGroup.Text = "Datei Entschlüsseln";
            this.decryptGroup.Visible = false;
            // 
            // chooseFileToDecrypt
            // 
            this.chooseFileToDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFileToDecrypt.Location = new System.Drawing.Point(682, 20);
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
            this.textBox4.Size = new System.Drawing.Size(635, 20);
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
            this.textBox5.Size = new System.Drawing.Size(635, 20);
            this.textBox5.TabIndex = 1;
            // 
            // fileToDecrypt
            // 
            this.fileToDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileToDecrypt.Location = new System.Drawing.Point(144, 22);
            this.fileToDecrypt.Name = "fileToDecrypt";
            this.fileToDecrypt.Size = new System.Drawing.Size(555, 20);
            this.fileToDecrypt.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 447);
            this.Controls.Add(this.decryptGroup);
            this.Controls.Add(this.encryptGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startEncryption);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CryptMe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.encryptGroup.ResumeLayout(false);
            this.encryptGroup.PerformLayout();
            this.decryptGroup.ResumeLayout(false);
            this.decryptGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startEncryption;
        private System.Windows.Forms.OpenFileDialog openFileForEncryptionDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileForDecryptionDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zumVerschlüsselnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zumEntschlüsselnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.GroupBox encryptGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
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

