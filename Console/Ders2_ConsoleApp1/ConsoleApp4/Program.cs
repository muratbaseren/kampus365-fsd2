namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Compiling hataları
            //string ad = "Murat";
            //Console.WriteLine(adi);  


            // Runtime Hataları
            //int deger = 3;
            //double sonuc = deger / 0;


            // Logic Hataları

            Console.Write("Lütfen bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi > 3)
                Console.WriteLine("Sayı büyüktür 3");
            Console.WriteLine("Sayı 3 e eşit ya da küçüktür.");



            //try
            //{
            //    int deger = 3;
            //    double sonuc = deger / 0;
            //}
            //catch (Exception hata)
            //{
            //    Console.WriteLine("Hata oluştu.");
            //    Console.WriteLine();
            //    Console.WriteLine("Hata Mesajı : " + hata.Message);
            //    Console.WriteLine();
            //    Console.WriteLine("Hata Detayı : " + hata.StackTrace);
            //}
            ////finally
            ////{

            ////}

            //Console.WriteLine();
            //Console.WriteLine("Proje çalışmaya devam ediyor.");
            //Console.WriteLine("Proje çalışmaya devam ediyor.");




        }
    }
}