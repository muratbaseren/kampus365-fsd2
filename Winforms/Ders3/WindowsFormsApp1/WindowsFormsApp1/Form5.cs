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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        public void NavigateUrl()
        {
            string url = txtAddress.Text.ToLower().Trim();

            if (url.StartsWith("http://") == false)
            {
                url = "http://" + url;
            }

            txtAddress.Text = url;
            lblAddress.Text = url;

            webBrowser1.Navigate(url);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            NavigateUrl();
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            

            if (e.KeyData == Keys.Enter)
            {
                NavigateUrl();

                //btnGo_Click(btnGo, EventArgs.Empty);
                //btnGo_Click(sender, EventArgs.Empty);
                //btnGo_Click(null, null);
            }
        }
    }
}
