using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox()
        {
            InitializeComponent();
        }

        private void buttons_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
