using Ganss.Excel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;
            lstItems.Items.Add(text);
        }

        private void btnUseStreamWriter_Click(object sender, EventArgs e)
        {
            // c:\users\murat\abc\
            // c:\users\murat\abc\murat.txt

            //string path = Application.StartupPath + "\\data.txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\data.txt";

            FileStream stream = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);

            foreach (string item in lstItems.Items)
            {
                writer.WriteLine(item);
            }

            writer.Close();
            stream.Close();

            MessageBox.Show("Dosya Kaydedildi.");
        }

        private void btnUseStreamReader_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\data.txt";

            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(stream);

            lstItems.Items.Clear();

            while (reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                lstItems.Items.Add(line);
            }

            reader.Close();
            stream.Close();
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            List<Product> items = new List<Product>();
            Random random = new Random();

            foreach (string item in lstItems.Items)
            {
                Product product = new Product();
                product.Name = item;
                product.Price = random.Next(100, 1000);

                items.Add(product);
            }

            ExcelMapper mapper = new ExcelMapper();
            mapper.Save("data.xlsx", items, "products");

            MessageBox.Show("Excel Dosya Kaydedildi.");
        }
    }
}