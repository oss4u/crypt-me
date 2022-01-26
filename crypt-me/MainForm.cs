using System;
using System.IO;
using System.Windows.Forms;
using CryptMe;

namespace CryptMe
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileForEncryptionDialog.ShowDialog(this) == DialogResult.OK)
            {
                AesCiphers aes = new AesCiphers();
                aes.FileEncrypt(openFileForEncryptionDialog.FileName, "HalloWelt");
            }

        }
    }
}
