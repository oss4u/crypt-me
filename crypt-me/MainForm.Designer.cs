
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
            this.SuspendLayout();
            // 
            // startEncryption
            // 
            this.startEncryption.Location = new System.Drawing.Point(663, 408);
            this.startEncryption.Name = "startEncryption";
            this.startEncryption.Size = new System.Drawing.Size(112, 30);
            this.startEncryption.TabIndex = 0;
            this.startEncryption.Text = "Encrypt";
            this.startEncryption.UseVisualStyleBackColor = true;
            this.startEncryption.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileForEncryptionDialog
            // 
            this.openFileForEncryptionDialog.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startEncryption);
            this.Name = "MainForm";
            this.Text = "CryptMe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startEncryption;
        private System.Windows.Forms.OpenFileDialog openFileForEncryptionDialog;
    }
}

