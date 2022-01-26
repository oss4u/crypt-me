using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptMe.ctrls
{
    public partial class EncryptionPanel : UserControl
    {
        public EncryptionPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileForEncryptionDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileForEncryptionDialog.FileName;
                string path = openFileForEncryptionDialog.FileName;
                txtFilename.Text = filename;
                if (checkBox1.Checked)
                {
                    txtFilenameEnc.Text = filename + ".aes.b64";
                }
                else
                {
                    txtFilenameEnc.Text = filename + ".aes";
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtFilename.Text != String.Empty) {
                if (checkBox1.Checked)
                {
                    txtFilenameEnc.Text = txtFilename.Text + ".aes.b64";
                }
                else
                {
                    txtFilenameEnc.Text = txtFilename.Text + ".aes";
                }
            }
        }

        private void changeCheck(object sender, EventArgs e)
        {
            if (txtFilename.Text != String.Empty &&
                txtFilenameEnc.Text != String.Empty &&
                txtPassword.Text != String.Empty &&
                txtPasswordConfirm.Text != String.Empty &&
                txtPassword.Text == txtPasswordConfirm.Text)
            {
                btnEncrypt.Enabled = true;
            }
            else
            {
                btnEncrypt.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AesUtils utils = new AesUtils();
            if (checkBox1.Checked)
            {
                string aesFile = Path.GetDirectoryName(txtFilenameEnc.Text) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(txtFilenameEnc.Text);
                utils.FileEncrypt(txtFilename.Text, aesFile, txtPassword.Text);
                Byte[] bytes = File.ReadAllBytes(aesFile);
                String file = Convert.ToBase64String(bytes);
                File.Delete(aesFile);
                File.WriteAllText(txtFilenameEnc.Text, file);
            }
            else
            {
                utils.FileEncrypt(txtFilename.Text, txtFilenameEnc.Text, txtPassword.Text);
            }
            string title = "CryptMe";
            string message = "Verschlüsselt";
            MessageBox.Show(message, title);

        }
    }
}
