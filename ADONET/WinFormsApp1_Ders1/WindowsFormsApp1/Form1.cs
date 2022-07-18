using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void btnConnectDatabase_Click(object sender, EventArgs e)
        {
            // MS SQL Client Provider 
            // MY SQL Client Provider
            // Oracle Client Provider

            string connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;";   // Windows
            //string connectionString = "Server=localhost;Database=Northwind;User Id=sa;Password=123123;";  // SQL

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();



            connection.Close();
        }
    }
}
