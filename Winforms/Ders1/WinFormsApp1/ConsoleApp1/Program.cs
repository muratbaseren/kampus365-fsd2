namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Matematik Class ve Static Class Olayı

            //Console.WriteLine("Hello, World!");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Title = "Pencere Başlığı";

            //Console.WriteLine("Toplama işlemi yapılacak.");
            //Console.WriteLine();

            //Console.Write("Sayı 1 : ");
            //int say1 = int.Parse(Console.ReadLine());

            //Console.Write("Sayı 2 : ");
            //int say2 = int.Parse(Console.ReadLine());

            //Matematik math = new Matematik();       //instance = nesne oluşumu
            //int sonuc = math.Topla(say1, say2);

            //Console.WriteLine();
            //Console.WriteLine("Sonuç : " + sonuc);

            //Matematik.Topla(5, 4);

            #endregion


            #region Random


            //Random random = new Random();
            //int rastgele1 = random.Next();
            //int rastgele2 = random.Next(100);
            //int rastgele3 = random.Next(100, 150);

            //Console.WriteLine(rastgele1);
            //Console.WriteLine(rastgele2);
            //Console.WriteLine(rastgele3);


            #endregion



            #region Kisi class 'ı anlatımı

            //Kisi kisi1 = new Kisi();
            //kisi1.Ad = "Murat";
            //kisi1.Soyad = "Başeren";
            //kisi1.Yas = 30;

            //Console.WriteLine("Ad : " + kisi1.Ad);
            //Console.WriteLine("Soyad : " + kisi1.Soyad);
            //Console.WriteLine("Yaş : " + kisi1.Yas);

            ////kisi1.EkranaYaz();
            ////Console.WriteLine(kisi1.BilgiVer());

            //Console.WriteLine();

            //Kisi kisi2 = new Kisi();
            //kisi2.Ad = "Yiğit";
            //kisi2.Soyad = "Başeren";
            //kisi2.Yas = 3;

            //Console.WriteLine("Ad : " + kisi2.Ad);
            //Console.WriteLine("Soyad : " + kisi2.Soyad);
            //Console.WriteLine("Yaş : " + kisi2.Yas);

            ////kisi2.EkranaYaz();
            ////Console.WriteLine(kisi2.BilgiVer());

            #endregion



            //Ogrenci ogr1 = new Ogrenci();
            //ogr1.AdSoyad = "Murat Başeren";
            //ogr1.Eposta = "murat@baseren.com";
            //ogr1.TelNo = "5558889977";
            //ogr1.Not1 = 10f;
            //ogr1.Not2 = 20f;
            //ogr1.Not3 = 30f;
            //ogr1.EkranaYaz();

            //Console.WriteLine();


            //Ogrenci ogr2 = new Ogrenci("Murat Başeren", "murat@baseren.com", "5558889977");
            //ogr2.Not1 = 10f;
            //ogr2.Not2 = 20f;
            //ogr2.Not3 = 30f;
            //ogr2.EkranaYaz();

            //Console.WriteLine();

            //Ogrenci ogr3 = new Ogrenci("Murat Başeren", "murat@baseren.com", "5558889977", 10f, 20f, 30f);
            //ogr3.EkranaYaz();

            //Console.WriteLine();




            Random random = new Random();
            Ogrenci[] ogrenciler = new Ogrenci[10];

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.AdSoyad = $"Öğrenci-{(i + 1)}";
                ogrenci.Eposta = $"ogrenci{(i + 1)}@gmail.com";
                ogrenci.TelNo = $"555888776{i}";
                ogrenci.Not1 = random.Next(0, 100);
                ogrenci.Not2 = random.Next(0, 100);
                ogrenci.Not3 = random.Next(0, 100);

                ogrenciler[i] = ogrenci;
            }

            foreach (Ogrenci ogr in ogrenciler)
            {
                ogr.EkranaYaz();
            }





            #region Para Kazanma Ödevi


            // Kullanıcıya sorsun, kaç kolon oynayacaksın.
            // 1-49 arası her kolon için 6 tahmin de bulunacak.
            // 6 değer içinde aynı sayılar olmaması gerekiyor.
            // küçükten büyüğe sıralıyarak aşağıdaki formtta en son tüm kolonları yazdıralım
            // [1,15,25,33,44,48]
            // [11,24,28,34,45,49]
            // ....
            // ....
            // ....
            // ....



            #endregion

        }
    }


}