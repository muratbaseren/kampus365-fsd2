namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteTitle("Hello World!");
            WriteTitle("Merhaba Dünya!");

            WriteTitle("Toplama İşlemi Yapıyorum");

            int sonuc = Sum(5, 4);
            Console.WriteLine("5 + 4 = " + sonuc);

            Console.WriteLine();


            int[] sayilar = new int[] { 3, 4, 5, 6, 7, 8, 9 };
            int sonuc2 = Sum(sayilar);
            Console.WriteLine("Toplam = " + sonuc2);

            Console.WriteLine();


            WriteTitle("Varsayılan ve Opsiyonel Parametreler");

            int sonuc3 = Sum(5);
            //int sonuc3 = Sum(5,6);
            Console.WriteLine("Sonuç = " + sonuc3);


            WriteTitle("Concat Metodu");
            string[] names = new string[] { "Kadir", "Murat", "Başeren" };

            string sonuc4 = Concat(names);
            Console.WriteLine(sonuc4);
            Console.WriteLine();


            string sonuc5 = Concat("Kadir", "Murat", "Başeren", "Kampüs 365", "Test");
            Console.WriteLine(sonuc5);
            Console.WriteLine();


        }

        static void WriteTitle(string title)
        {
            Console.WriteLine(title);

            for (int i = 0; i < title.Length; i++)
            {
                Console.Write("=");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        // Method Overloading = Metot Aşırı yükleme

        static int Sum(int a, int b = 0)
        {
            //int result = a + b;
            //return result;

            return a + b;
        }

        //static bool Sum(int x, int y)
        //{
        //    //int result = a + b;
        //    //return result;

        //    return true;
        //}

        static int Sum(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }

        static string Concat(params string[] metinler)
        {
            string result = "";

            foreach (string m in metinler)
            {
                result += m + ",";


                //int i = Array.IndexOf(metinler, m);

                //if (i == metinler.Length - 1)
                //{
                //    result += m;
                //}
                //else
                //{
                //    result += m + ",";
                //}
            }

            result = result.TrimEnd(',');

            return result;
        }
    }
}