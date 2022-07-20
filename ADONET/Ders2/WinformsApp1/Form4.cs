using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsApp1
{
    public partial class Form4 : Form
    {
        DataSet _dataSet;


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            _dataSet = new DataSet("mydata");

            DataTable suppliers = new DataTable("Suppliers");
            suppliers.Columns.Add("CompanyName", typeof(string));
            suppliers.Columns.Add("Phone", typeof(string));
            suppliers.Columns.Add("Address", typeof(string));

            DataTable shippers = new DataTable("Shippers");
            shippers.Columns.Add("CompanyName", typeof(string));
            shippers.Columns.Add("City", typeof(string));
            shippers.Columns.Add("Country", typeof(string));
            shippers.Columns.Add("Limit", typeof(int));

            _dataSet.Tables.Add(suppliers);
            _dataSet.Tables.Add(shippers);

            dataGridView1.DataSource = suppliers;
            dataGridView2.DataSource = shippers;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Verileri Kaydet";
            //saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = "XML Belgeleri|*.xml";
            saveFileDialog.FileName = _dataSet.DataSetName;
            saveFileDialog.RestoreDirectory = true;

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                _dataSet.WriteXml(filePath);

                MessageBox.Show("Veriler kaydedildi.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Verileri Aç";
            //openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "XML Belgeleri|*.xml";
            openFileDialog.RestoreDirectory = true;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                _dataSet = new DataSet("mydata");
                string filePath = openFileDialog.FileName;
                _dataSet.ReadXml(filePath);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _dataSet.Tables["Suppliers"];

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = _dataSet.Tables["Shippers"];
            }
        }
    }
}
