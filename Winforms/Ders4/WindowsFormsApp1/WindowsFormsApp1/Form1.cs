using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTuple_Click(object sender, EventArgs e)
        {

            //Kisi kisi1 = new Kisi();
            //kisi1.Ad = "Murat";
            //kisi1.Soyad = "Başeren";
            //kisi1.Yas = 30;

            //MessageBox.Show(kisi1.Ad + " " + kisi1.Soyad + " (" + kisi1.Yas + ")");
            //MessageBox.Show($"{kisi1.Ad} {kisi1.Soyad} ({kisi1.Yas})");


            #region Tuple..

            //Tuple<string, string, int, decimal> kisi2 = 
            //    new Tuple<string, string, int, decimal>("Murat", "Başeren", 30, 100.5m);

            //MessageBox.Show($"Ad : {kisi2.Item1}\nSoyad : {kisi2.Item2}\nYaş : {kisi2.Item3}\nMaaş : {kisi2.Item4}");

            #endregion


            #region İyileştirilmiş Tuple..

            (string Ad, string Soyad, int Yas, decimal Maas) kisi3 = ("Murat", "Başeren", 30, 102.5m);
            MessageBox.Show($"Ad : {kisi3.Ad}\nSoyad : {kisi3.Soyad}\nYaş : {kisi3.Yas}\nMaaş : {kisi3.Maas}");

            #endregion

        }

        private void btnShowMyMessageBox_Click(object sender, EventArgs e)
        {
            MyMessageBox myMessageBox = new MyMessageBox();

            myMessageBox.Text = "Bilgilendirme";
            myMessageBox.lblMessage.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec bibendum purus tortor. Mauris est massa, sagittis eu mi id, posuere molestie purus.";
            //myMessageBox.btnOk.Visible = true;

            myMessageBox.btnYes.Visible = true;
            myMessageBox.btnNo.Visible = true;
            myMessageBox.btnCancel.Visible = true;

            myMessageBox.pbIcon.Image = Properties.Resources.info_128;

            myMessageBox.ShowDialog();
        }

        private void btnShowSozlesme_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.sozlesme_metni);
        }
    }
}
