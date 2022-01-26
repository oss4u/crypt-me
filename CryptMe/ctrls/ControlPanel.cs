using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptMe.ctrls
{
    public partial class ControlPanel : UserControl
    {
        private List<Run> runners = new List<Run>();
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {

        }

        public void AddRunner(Run oneRun)
        {
            runners.Add(oneRun);
        }

        public void RemoveRunner(Run oneRun)
        {
            runners.Remove(oneRun);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (Run oneRun in runners)
            {
                oneRun.Run();
            }
        }
    }
}
