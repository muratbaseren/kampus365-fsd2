namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMetin.Text = File.ReadAllText(Application.StartupPath + "\\sablon.txt");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;

            metin = metin.Replace("${Ad}", txtAd.Text).Replace("${Soyad}",txtSoyad.Text);

            //string path = Application.StartupPath + $"\\dosya_{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.txt";

            string path = Application.StartupPath + $"\\dosya_{txtAd.Text}-{txtSoyad.Text}.txt";

            File.WriteAllText(path, metin);

            MessageBox.Show("Dosya Yazýldý.");
        }
    }
}