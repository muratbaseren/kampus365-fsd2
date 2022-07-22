using Dapper;
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

namespace WinformsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string _connectionString = "Data Source=localhost;Database={DatabaseName};Integrated Security=True;";
        string _newDatabase = string.Empty;

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            string sql = "CREATE DATABASE ";

            using (SqlConnection connection = new SqlConnection(_connectionString.Replace("{DatabaseName}", "master")))
            {
                _newDatabase = txtDatabaseName.Text;
                sql += $"[{_newDatabase}]";

                int affectedRows = connection.Execute(sql);

                MessageBox.Show("Veri tabanı oluşturuldu.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCreateTable.Enabled = true;
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            string sql = $"CREATE TABLE [{txtTableName.Text}] ( [CategoryID] [int] IDENTITY(1,1) NOT NULL, [CategoryName] [nvarchar](15) NOT NULL)";

            using (SqlConnection connection = new SqlConnection(_connectionString.Replace("{DatabaseName}", _newDatabase)))
            {
                int affectedRows = connection.Execute(sql);

                MessageBox.Show($"{txtTableName.Text} tablosu oluşturuldu.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
