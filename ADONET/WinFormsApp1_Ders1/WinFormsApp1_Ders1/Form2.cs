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

namespace WinFormsApp1_Ders1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;";   // Windows
        SqlConnection connection;

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);

            ReadAllCategories();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReadAllCategories();
        }

        private void ReadAllCategories()
        {
            string query = "SELECT CategoryName FROM Categories";
            SqlCommand command = new SqlCommand(query, connection);

            lstCategories.Items.Clear();

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                lstCategories.Items.Add(reader.GetString(0));
            }

            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtNewCategoryName.Text.Trim();

            //string query = $"INSERT INTO Categories VALUES ('{categoryName}',NULL,NULL)";
            //SqlCommand command = new SqlCommand(query, connection);

            string query = $"INSERT INTO Categories VALUES (@CatName,NULL,NULL)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CatName", categoryName);

            connection.Open();
            int affectedRowCount = command.ExecuteNonQuery();
            connection.Close();

            if (affectedRowCount > 0)
            {
                MessageBox.Show("New category added.");
                ReadAllCategories();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newCatName = txtCategoryName.Text.Trim();
            string oldCatName = lstCategories.Text;

            if (lstCategories.SelectedIndex == -1)
            {
                return;
            }

            string query = $"UPDATE Categories SET CategoryName = @NewCatName WHERE CategoryName = @OldCatName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NewCatName", newCatName);
            command.Parameters.AddWithValue("@OldCatName", oldCatName);

            connection.Open();
            int affectedRowCount = command.ExecuteNonQuery();
            connection.Close();

            if (affectedRowCount > 0)
            {
                MessageBox.Show("Categor(ies) updated.");
                ReadAllCategories();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string catName = lstCategories.Text;

            if (lstCategories.SelectedIndex == -1)
            {
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure want to delete '{catName}' category?", "Delete Category", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            string query = $"DELETE FROM Categories WHERE CategoryName = @CatName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CatName", catName);

            connection.Open();
            int affectedRowCount = command.ExecuteNonQuery();
            connection.Close();

            if (affectedRowCount > 0)
            {
                MessageBox.Show("Categor(ies) deleted.");
                ReadAllCategories();
            }
        }
    }
}
