namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;

            sayi = 8;
            sayi = 4;

            byte kucukSayi = 0;

            string metin = "Merhaba Dünya";
            bool evetHayir = false;
            char harf = 'h';

            // yorum satırı

            /*
             çok satırlı
            yorum
            bloğu
             */

            //float virgullu1 = 1.1f;
            //double virgullu2 = 1.2;
            decimal virgullu3 = 1.4m;



            int sonuc = 3 + 5;
            Console.Write(sonuc);
            Console.WriteLine();


            //string ekrandanOkunan = Console.ReadLine();
            //Console.WriteLine(ekrandanOkunan);

            Console.Write("Adınız :");
            string ad = Console.ReadLine();

            Console.Write("Soyadınız : ");
            string soyad = Console.ReadLine();

            Console.Write("Yaşınız : ");
            string yas = Console.ReadLine();    // "6"

            int yas2 = int.Parse(yas);          // 6
            yas2 = yas2 + 10;                   // 16
            //yas2 += 10;

            Console.WriteLine(ad + " " + soyad + " [" + yas2 + "]");
            // Murat Başeren [16]
        }
    }
}