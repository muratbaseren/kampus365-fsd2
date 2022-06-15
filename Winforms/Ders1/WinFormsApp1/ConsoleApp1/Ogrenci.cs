using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ogrenci
    {
        public string AdSoyad;
        public string Eposta;
        public string TelNo;
        public float Not1;
        public float Not2;
        public float Not3;


        // Constructor = inşa edici metot
        public Ogrenci()
        {

        }

        public Ogrenci(string adsoyad, string eposta, string telno)
        {
            AdSoyad = adsoyad;
            Eposta = eposta;
            TelNo = telno;
        }

        public Ogrenci(string adsoyad, string eposta, string telno, float not1, float not2, float not3)
        {
            AdSoyad = adsoyad;
            Eposta = eposta;
            TelNo = telno;
            Not1 = not1;
            Not2 = not2;
            Not3 = not3;
        }

        public float NotHesapla()
        {
            float sonuc = (Not1 * 0.2f) + (Not2 * 0.2f) + (Not3 * 0.6f);
            return sonuc;
        }

        public void EkranaYaz()
        {
            float notOrtalamasi = NotHesapla();
            Console.WriteLine($"{AdSoyad} ({Eposta}) --> Not : {notOrtalamasi}");
        }
    }
}
