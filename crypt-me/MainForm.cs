using System;
using System.IO;
using System.Windows.Forms;
using CryptMe;
using CryptMe.ctrls;

namespace CryptMe
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {

            if (openFileForEncryptionDialog.ShowDialog(this) == DialogResult.OK)
            {

                AesUtils aes = new AesUtils();
                aes.FileEncrypt(openFileForEncryptionDialog.FileName, "HalloWelt");
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {

            if (openFileForDecryptionDialog.ShowDialog(this) == DialogResult.OK)
            {
                AesUtils aes = new AesUtils();
                string currentDir = Path.GetDirectoryName(openFileForDecryptionDialog.FileName);
                string targetFilename = Path.GetFileNameWithoutExtension(openFileForDecryptionDialog.FileName);

                aes.FileDecrypt(openFileForDecryptionDialog.FileName, currentDir + "\\" + targetFilename, "HalloWelt");
            }
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void verschlüsselnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (encryptionPanel == null)
            {
                encryptionPanel = new EncryptionPanel();
            }
            
        }

        private void entschlüsselnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (decryptionPanel == null)
            {
                decryptionPanel = new DecryptionPanel();
            }
        }
    }
}
