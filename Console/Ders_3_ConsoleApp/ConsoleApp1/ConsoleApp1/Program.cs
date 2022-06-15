namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[3];
            //int[] sayilar = new int[] { 5, 6, 7 };

            sayilar[0] = 5;
            sayilar[1] = 6;
            sayilar[2] = 7;
            //sayilar[3] = 8;

            //Console.WriteLine(sayilar[0]);

            #region String Dizisi ve For ile Dönme

            string[] metinler = new string[] { "Murat", "Başeren", "Kadir", "Kampüs365", "C#", "Yazılım" };

            //Console.WriteLine(metinler[0]);
            //Console.WriteLine(metinler[1]);
            //Console.WriteLine(metinler[2]);
            //Console.WriteLine(metinler[3]);

            //Console.WriteLine(metinler.Length);

            //for (int i = 0; i < 5; i++)
            //for (int i = 0; i < metinler.Length; i++)
            //{
            //    string metin = metinler[i];
            //    Console.WriteLine(metin);
            //}

            #endregion


            #region Dinamik boyuttlu dizi

            //Console.Write("Depoya girilecek ürün adedi : ");
            //int count = int.Parse(Console.ReadLine());

            //string[] products = new string[count];

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.Write((i + 1) + ". Ürün Adı : ");
            //    string productName = Console.ReadLine();
            //    products[i] = productName;
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("ÜRÜNLER");
            //Console.WriteLine("=======");

            //for (int i = 0; i < products.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". Ürün : " + products[i]);
            //} 

            #endregion


            #region Dizi Boyutlandırma
            //string[] products = new string[0];
            ////products.Length += 1;
            //string entry = "";
            //int i = 0;

            //do
            //{
            //    Console.Write((i + 1) + ". Ürün Adı : ");
            //    entry = Console.ReadLine();

            //    if (entry == "")
            //        break;

            //    //if (entry != "")
            //    //{
            //    Array.Resize(ref products, products.Length + 1);
            //    products[i] = entry;

            //    i++;
            //    //}

            //} while (entry != "");


            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("ÜRÜNLER");
            //Console.WriteLine("=======");

            //for (int k = 0; k < products.Length; k++)
            //{
            //    Console.WriteLine((k + 1) + ". Ürün : " + products[k]);
            //} 
            #endregion


            #region Foreach döngüsü
            string[] degerler = new string[2];

            degerler[0] = "aaa";
            degerler[1] = "ddd";
            degerler[2] = "sss";

            //for (int i = 0; i < degerler.Length; i++)
            //{
            //    string deger = degerler[i];
            //    Console.WriteLine(deger);
            //}

            //int i = 0;

            foreach (string deger in degerler)
            {
                int i = Array.IndexOf(degerler, deger);

                Console.WriteLine((i + 1) + ". Değer : " + deger);
                //i++;
            } 
            #endregion


            #region Console Özellikleri (Properties)

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("hello world!");

            //Console.Beep();

            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("hello world!");

            //Console.ForegroundColor = ConsoleColor.White;
            //Console.ResetColor();
            //Console.WriteLine("hello world!");

            //Console.WriteLine("Window Coordinates : " + Console.WindowLeft + ";" + Console.WindowTop);

            //Console.WriteLine("Window Size : " + Console.WindowWidth + ";" + Console.WindowHeight);

            #endregion
        }
    }
}