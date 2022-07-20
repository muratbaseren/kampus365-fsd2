using System.Data;
using System.Data.SqlClient;

namespace WinformsApp1
{
    public partial class Form3 : Form
    {
        string _connectionString = string.Empty;
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlCommandBuilder sqlCommandBuilder;
        DataTable dataTable;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            _connectionString = Program.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value;

            connection = new SqlConnection(_connectionString);
            command = new SqlCommand("SELECT [ShipperID],[CompanyName],[Phone] FROM [Shippers]", connection);
            adapter = new SqlDataAdapter(command);
            sqlCommandBuilder = new SqlCommandBuilder(adapter);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            adapter.Update(dataTable);
        }
    }
}
