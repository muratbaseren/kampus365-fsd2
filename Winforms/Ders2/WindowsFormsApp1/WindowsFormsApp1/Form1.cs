using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trcOpacity_Scroll(object sender, EventArgs e)
        {
            int opacity = trcOpacity.Value;
            double val = ((double)opacity) / 100;

            this.Opacity = val;
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            frmUserManager frm = new frmUserManager();
            frm.ShowDialog();
        }

        private void mnuCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestartApp_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}
