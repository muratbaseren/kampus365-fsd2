using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kisi
    {
        public string Ad;
        public string Soyad;
        public int Yas;

        // Constructor
        public Kisi()
        {

        }

        public void EkranaYaz()
        {
            // String Interpolation
            Console.WriteLine($"{Ad} {Soyad} ({Yas})");
        }

        public string BilgiVer()
        {
            return $"{Ad} {Soyad} - {Yas}";
        }
    }
}
