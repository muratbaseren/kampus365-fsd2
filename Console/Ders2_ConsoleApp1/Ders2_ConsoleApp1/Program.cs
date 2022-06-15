namespace Ders2_ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!"); // Hello, World!
            //Console.WriteLine("5");             // 5
            //Console.WriteLine(5);               // 5
            //Console.WriteLine(true);            // true

            //Console.ReadLine();

            // "14.3"


            #region Implicit Type Converting

            string metin = "14.3";
            double gercekSayi = double.Parse(metin);

            Console.WriteLine("5" + "5");
            Console.WriteLine(5 + 5);

            Console.WriteLine("5" + "5");
            Console.WriteLine("5" + 5 + 4);

            #endregion


            #region Explicit Type Converting

            int sayi1 = 10;
            bool varmi = true;
            double sayi2 = 15.4;

            string sayi1Str = sayi1.ToString();
            string varmiStr = varmi.ToString();
            string sayi2Str = sayi2.ToString();

            #endregion


            #region Convert Sınıfı Kullanımı

            string donenDeger1 = Convert.ToString(sayi1);
            bool donenDeger2 = Convert.ToBoolean("true");

            byte deger3 = 0;
            bool donenDeger3 = Convert.ToBoolean(deger3);

            Console.WriteLine(donenDeger3);

            #endregion


            #region Boxing Unboxing Casting

            object obj1 = "Murat";      // boxing
            object obj2 = 4;
            object obj3 = true;
            object obj4 = 14.3;
            object obj5 = 'a';

            string ad = obj1.ToString();
            int yas = (int)obj2;        // Cast - Unboxing
            bool yasiyormu = (bool)obj3; 

            #endregion
        }
    }
}