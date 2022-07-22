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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string _connectionString = "Data Source=localhost;Database=Northwind;Integrated Security=True;";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            //SqlCommand cmd = new SqlCommand("SELECT [CategoryID] ,[CategoryName] ,[Description] FROM [Northwind].[dbo].[Categories]", connection);
            
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT [CategoryID] ,[CategoryName] ,[Description] FROM [Northwind].[dbo].[Categories]";

            List<Category> categories = new List<Category>();

            //connection.Open();
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    Category category = new Category();
            //    category.CategoryID = reader.GetInt32("CategoryID");
            //    category.CategoryName = reader.GetString("CategoryName");
            //    category.Description = reader.GetString("Description");

            //    categories.Add(category);
            //}

            //connection.Close();



            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Category category = new Category();
                category.CategoryID = (int)dr["CategoryID"];
                category.CategoryName = dr["CategoryName"].ToString();
                category.Description = dr["Description"].ToString();

                categories.Add(category);
            }

            listBox1.DataSource = categories;
            listBox1.DisplayMember = "CategoryName";
            listBox1.ValueMember = "CategoryID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            {
                Category selectedCategory = (Category)listBox1.SelectedItem;

                SqlConnection connection = new SqlConnection(_connectionString);

                //SqlCommand cmd = new SqlCommand("SELECT [CategoryID] ,[CategoryName] ,[Description] FROM [Northwind].[dbo].[Categories]", connection);

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM [Northwind].[dbo].[Categories] WHERE CategoryID = @Id";

                command.Parameters.AddWithValue("@Id", selectedCategory.CategoryID);

                connection.Open();

                //command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
