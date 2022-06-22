using System.Text.Json;
using System.Xml.Serialization;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            string category = txtProductCat.Text;
            decimal price = nudProductPrice.Value;

            Product product = new Product();
            product.Name = name;
            product.Category = category;
            product.Price = price;
            
            products.Add(product);

            listBox1.Items.Add($"{name} - {category} ({price})");
        }

        private void btnXmlSave_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

            FileStream fileStream = new FileStream(Application.StartupPath + "\\data.xml", FileMode.Create);
            serializer.Serialize(fileStream, products);

            fileStream.Close();

            MessageBox.Show("Veriler kaydedildi.");
        }

        private void btnReadXml_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

            FileStream fileStream = new FileStream(Application.StartupPath + "\\data.xml", FileMode.Open);
            object obj = serializer.Deserialize(fileStream);

            products = (List<Product>)obj;

            fileStream.Close();

            listBox1.Items.Clear();

            foreach (Product product in products)
            {
                listBox1.Items.Add($"{product.Name} - {product.Category} ({product.Price})");
            }
        }

        private void btnJSONSave_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.IncludeFields = true;
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;

            string json = JsonSerializer.Serialize<List<Product>>(products, options);

            File.WriteAllText(Application.StartupPath + "\\data.json", json);
            MessageBox.Show("Veriler kaydedildi.");
        }

        private void btnReadFromJSON_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.IncludeFields = true;
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;

            string json = File.ReadAllText(Application.StartupPath + "\\data.json");

            products = JsonSerializer.Deserialize<List<Product>>(json, options);

            listBox1.Items.Clear();

            foreach (Product product in products)
            {
                listBox1.Items.Add($"{product.Name} - {product.Category} ({product.Price})");
            }
        }
    }
}