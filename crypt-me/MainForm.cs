using System;
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
            AesEncrypt aes = new AesEncrypt();
        }
    }
}
