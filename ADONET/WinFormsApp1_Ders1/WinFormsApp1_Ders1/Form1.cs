using MFramework.Services.FakeData;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1_Ders1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnectDatabase_Click(object sender, EventArgs e)
        {
            // install nuget package : System.Data.SqlClient

            string connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;";   // Windows
            //string connectionString = "Server=localhost;Database=Northwind;User Id=sa;Password=123123;";  // SQL

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname = NameData.GetFullName();
            MessageBox.Show(fullname);
        }

        private void btnInsertNewCategory_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;";   // Windows
            //string connectionString = "Server=localhost;Database=Northwind;User Id=sa;Password=123123;";  // SQL

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Categories VALUES ('Electronic',NULL,NULL)";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }

        private void btnReadAllCategories_Click(object sender, EventArgs e)
        {
            lstCategories.Items.Clear();

            string connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;";   // Windows
            //string connectionString = "Server=localhost;Database=Northwind;User Id=sa;Password=123123;";  // SQL

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT CategoryID, CategoryName, Description FROM Categories";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                //string categoryId = reader["CategoryID"].ToString();
                //int catId = (int)reader["CategoryID"];

                //string categoryId = reader["CategoryID"].ToString();
                //string categoryName = reader["CategoryName"].ToString();
                //string categoryDesc = reader["Description"].ToString();

                string categoryId = reader.GetInt32(0).ToString();
                string categoryName = reader.GetString(1);
                string categoryDesc = "";

                if (reader.IsDBNull("Description") == false)
                {
                    categoryDesc = reader.GetString(2);
                }

                string txt = $"{categoryName}({categoryId}) - {categoryDesc}";
                lstCategories.Items.Add(txt);
            }

            connection.Close();
        }

        private void btnReadAllCategoriesGrid_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;";   // Windows
            //string connectionString = "Server=localhost;Database=Northwind;User Id=sa;Password=123123;";  // SQL

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT CategoryID, CategoryName, Description FROM Categories";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Cat ID", typeof(int));
            dt.Columns.Add("Cat Name", typeof(string));
            dt.Columns.Add("Cat Desc", typeof(string));

            while (reader.Read())
            {
                DataRow row = dt.NewRow();
                row["Cat ID"] = reader.GetInt32(0);
                row["Cat Name"] = reader.GetString(1);

                if (reader.IsDBNull("Description") == false)
                {
                    row["Cat Desc"] = reader.GetString(2);
                }

                dt.Rows.Add(row);
            }

            connection.Close();

            dataGridView1.DataSource = dt;
        }

        private void btnExecuteScalar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=Northwind;Trusted_Connection=True;";   // Windows
            //string connectionString = "Server=localhost;Database=Northwind;User Id=sa;Password=123123;";  // SQL

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT COUNT(*) FROM Categories";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            object result = command.ExecuteScalar();

            int count = (int)result;
            label1.Text = $"{count.ToString()} adet kategori vardýr.";

            connection.Close();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form = new();
            form.ShowDialog();
        }
    }
}