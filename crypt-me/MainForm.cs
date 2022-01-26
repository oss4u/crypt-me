using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using CryptMe;
using CryptMe.ctrls;

namespace CryptMe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void schliessenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecryptionPanel panel = new DecryptionPanel();
            panel.Dock = DockStyle.Fill;
            panel.Enabled = true;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(panel);
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EncryptionPanel panel = new EncryptionPanel();
            panel.Dock = DockStyle.Fill;
            panel.Enabled = true;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(panel);
        }

    }
}