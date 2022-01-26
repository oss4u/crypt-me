using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptMe.ctrls
{
    public partial class DecryptionPanel : UserControl, Run
    {
        public DecryptionPanel()
        {
            InitializeComponent();
            controlPanel1.AddRunner(this);
        }

        private void chooseFileToDecrypt_Click(object sender, EventArgs e)
        {
            if (openFileForDecryptionDialog.ShowDialog(this) == DialogResult.OK)
            {
                string extension = Path.GetExtension(openFileForDecryptionDialog.FileName);
                string path = Path.GetDirectoryName(openFileForDecryptionDialog.FileName);
                Debug.WriteLine("Extension: " + extension);
                if (extension == ".b64")
                {
                    string b64FileName = openFileForDecryptionDialog.FileName;
                    fileToDecrypt.Text = b64FileName;
                    string aesFileName = path + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(b64FileName);
                    b64Intermediate.Text = aesFileName;
                    b64Intermediate.Enabled = true;
                    cbDecodeB64.Enabled = true;
                    txtFilename.Text = path + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(aesFileName);
                } 
                else if (extension == ".aes")
                {
                    string aesFileName = openFileForDecryptionDialog.FileName;
                    fileToDecrypt.Text = aesFileName;
                    b64Intermediate.Enabled = false;
                    cbDecodeB64.Enabled = false;
                    string fileName = Path.GetFileNameWithoutExtension(aesFileName);
                    txtFilename.Text = path + Path.DirectorySeparatorChar + fileName;
                }
                
            }
        }

        private void changeCheck(object sender, EventArgs e)
        {
            if (txtPassword.Text != String.Empty &&
                txtPasswordConfirm.Text != String.Empty &&
                txtPassword.Text == txtPasswordConfirm.Text &&
                txtFilename.Text != String.Empty)
            {
                controlPanel1.OkBtnEnabled = true;
            }
            else
            {
                controlPanel1.OkBtnEnabled = false;
            }
        }


        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            decrypt();
        }

        public void Run()
        {
            decrypt();
        }

        private void decrypt()
        {
            AesUtils utils = new AesUtils();
            if (cbDecodeB64.Checked)
            {
                Byte[] bytes = Convert.FromBase64String(File.ReadAllText(fileToDecrypt.Text));
                File.WriteAllBytes(b64Intermediate.Text, bytes);
                utils.FileDecrypt(b64Intermediate.Text, txtFilename.Text, txtPassword.Text);
            }
            else
            {
                utils.FileDecrypt(fileToDecrypt.Text, txtFilename.Text, txtPassword.Text);
            }
            string title = "CryptMe";
            string message = "Entschlüsselt";
            MessageBox.Show(message, title);
        }
    }
}
