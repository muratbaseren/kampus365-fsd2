using System.Data;
using System.Data.SqlClient;

namespace WinformsApp1
{
    public partial class Form1 : Form
    {
        string _connectionString = "Data Source=localhost; Initial Catalog=Northwind;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadReportNames();
        }

        private void btnRefreshReportNames_Click(object sender, EventArgs e)
        {
            LoadReportNames();
        }

        private void LoadReportNames()
        {
            // Data Source=localhost; Initial Catalog=Northwind;Integrated Security=True;
            // Data Source=localhost; Initial Catalog=Northwind;Integrated Security=SSPI;
            // Data Source=localhost; Initial Catalog=Northwind;User Id=sa; Password=123123;
            // Server=localhost; Database=Northwind; Trusted_Connection=true;

            string query = "SELECT name FROM sys.views ORDER BY name ASC";

            SqlConnection connection = new SqlConnection(_connectionString);
            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = _connectionString;

            SqlCommand command = new SqlCommand(query, connection);

            //SqlCommand command = new SqlCommand();
            //command.CommandText = query;
            //command.Connection = connection;

            cmbReportNames.Items.Clear();

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string viewName = reader.GetString("name");
                    cmbReportNames.Items.Add(viewName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu.");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed && connection.State != ConnectionState.Broken)
                {
                    connection.Close();
                }
            }

            dgDataView.DataSource = null;
        }

        private void cmbReportNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReportNames.SelectedIndex == -1)
                return;

            string reportName = cmbReportNames.Text;

            string query = $"SELECT * FROM [{reportName}]";
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dgDataView.DataSource = dataTable;
        }

        private void btnStoredProcedure_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void btnCommandBuilder_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }

        private void btnDataSet_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.ShowDialog();
        }
    }
}