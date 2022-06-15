namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Lütfen bir sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //bool dogru = true;
            //bool yanlis = false;


            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girdiğiniz sayı çift dir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz sayı tek dir.");
            //}




            //if (sayi > 3)
            //{
            //    Console.WriteLine("Sayı 3 den büyüktür.");
            //}
            //else if (sayi == 3)
            //{
            //    Console.WriteLine("Sayı 3 e eşittir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 3 den küçüktür.");
            //}




            //if(sayi >= 3)
            //{
            //    if(sayi == 3)
            //    {
            //        Console.WriteLine("Sayı 3 e eşittir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı 3 den büyüktür.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 3 den küçüktür.");
            //}


            // YADA-VEYA (OR)
            //if (sayi > 3 || sayi == 3)
            //{
            //    if (sayi == 3)
            //    {
            //        Console.WriteLine("Sayı 3 e eşittir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı 3 den büyüktür.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 3 den küçüktür.");
            //}



            // VE (AND)
            //if (sayi > 3 && sayi < 9)
            //{
            //    Console.WriteLine("Girdiniz sayı 3 ile 9 arasındadır.");
            //}
            //else if (sayi == 3)
            //{
            //    Console.WriteLine("Girdiğiniz sayı 3 'dür.");
            //}
            //else if (sayi == 9)
            //{
            //    Console.WriteLine("Girdiğiniz sayı 9 'dür.");
            //}
            //else
            //{
            //    //Console.WriteLine("Girdiğiniz sayı 3 ve 9 dahil bu aralıkta değildir.");

            //    if (sayi > 9)
            //    {
            //        Console.WriteLine("Girdiğiniz sayı 9 dan büyüktür.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Girdiğiniz sayı 3 den küçüktür.");
            //    }
            //}




            //Console.Write("Kullanıcı adınız : ");
            //string username = Console.ReadLine();

            //Console.Write("Şifreniz : ");
            //string password = Console.ReadLine();

            //if (username == "murat" && password == "123")
            //{
            //    Console.WriteLine("Şifre doğrulama başarılı.");
            //} 
            //else
            //{
            //    Console.WriteLine("Kullanıcı adı ya da şifre hatalı");
            //}


            Console.Write("Lütfen bir sayı giriniz : ");
            int deger = int.Parse(Console.ReadLine());

            //if(deger > 3) 
            //    Console.WriteLine("asdsad");
            //else 
            //    Console.WriteLine("qweqew");

            // ?: operatörü = Ternary Operatörü
            string sonuc = (deger > 3) ? "Sayı 3 den büyüktür." : "Sayı 3 den küçüktür.";
            //string sonuc = (deger > 3) ? "Sayı 3 den büyüktür." : ((deger == 3) ? "Sayı 3 e eşittir." : "Sayı 3 den küçüktür.");

            Console.WriteLine(sonuc);

        }
    }
}