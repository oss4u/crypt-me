
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

        private ctrls.DecryptionPanel decryptionPanel;
        private ctrls.EncryptionPanel encryptionPanel;

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileForEncryptionDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFileForDecryptionDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zumVerschlüsselnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zumEntschlüsselnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verschlüsselnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entschlüsselnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blankPanel = new System.Windows.Forms.Panel();
            this.controlPanel1 = new CryptMe.ctrls.ControlPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileForEncryptionDialog
            // 
            this.openFileForEncryptionDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.verschlüsselnToolStripMenuItem,
            this.entschlüsselnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 24);
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
            this.dateiÖffnenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
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
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // verschlüsselnToolStripMenuItem
            // 
            this.verschlüsselnToolStripMenuItem.Name = "verschlüsselnToolStripMenuItem";
            this.verschlüsselnToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.verschlüsselnToolStripMenuItem.Text = "Verschlüsseln";
            this.verschlüsselnToolStripMenuItem.Click += new System.EventHandler(this.verschlüsselnToolStripMenuItem_Click);
            // 
            // entschlüsselnToolStripMenuItem
            // 
            this.entschlüsselnToolStripMenuItem.Name = "entschlüsselnToolStripMenuItem";
            this.entschlüsselnToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.entschlüsselnToolStripMenuItem.Text = "Entschlüsseln";
            this.entschlüsselnToolStripMenuItem.Click += new System.EventHandler(this.entschlüsselnToolStripMenuItem_Click);
            // 
            // blankPanel
            // 
            this.blankPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blankPanel.Location = new System.Drawing.Point(0, 24);
            this.blankPanel.Name = "blankPanel";
            this.blankPanel.Size = new System.Drawing.Size(823, 518);
            this.blankPanel.TabIndex = 4;
            // 
            // controlPanel1
            // 
            this.controlPanel1.CloseBtnEnabled = true;
            this.controlPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPanel1.Location = new System.Drawing.Point(0, 542);
            this.controlPanel1.Name = "controlPanel1";
            this.controlPanel1.OkBtnEnabled = true;
            this.controlPanel1.Size = new System.Drawing.Size(823, 54);
            this.controlPanel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 596);
            this.Controls.Add(this.blankPanel);
            this.Controls.Add(this.controlPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CryptMe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileForEncryptionDialog;
        private System.Windows.Forms.OpenFileDialog openFileForDecryptionDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateiÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zumVerschlüsselnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zumEntschlüsselnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verschlüsselnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entschlüsselnToolStripMenuItem;
        private ctrls.ControlPanel controlPanel1;
        private System.Windows.Forms.Panel blankPanel;
    }
}

