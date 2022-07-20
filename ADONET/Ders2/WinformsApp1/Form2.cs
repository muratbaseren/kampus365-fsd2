using System.Data;
using System.Data.SqlClient;

namespace WinformsApp1
{
    public partial class Form2 : Form
    {
        string _connectionString = string.Empty;
        string _procedureName = string.Empty;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _connectionString = Program.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
            _procedureName = Program.Configuration.GetSection("StoredProcedureSettings:Name").Value;

            Text = Program.Configuration.GetSection("AppSettings:FormTitle").Value;
            lblReportName.Text = Program.Configuration.GetSection("AppSettings:ReportName").Value;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            SqlConnection connection = new SqlConnection(_connectionString);
            
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = _procedureName;
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Beginning_Date", startDate);
            command.Parameters.AddWithValue("@Ending_Date", endDate);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
