namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("╗");

            string[] products = new string[0];
            string islem;

            do
            {
                Console.Clear();

                WriteTitle("Sample Console Application");
                Console.WriteLine("[1] Ürün Ekleme");
                Console.WriteLine("[2] Ürün Listeleme");
                Console.WriteLine("[3] Ürün Güncelleme");
                Console.WriteLine("[4] Ürün Silme");
                Console.WriteLine("[0] Çıkış");
                Console.WriteLine();

                Console.Write("Lütfen yapmak istediğiniz işlemi giriniz :");
                islem = Console.ReadLine();

                switch (islem)
                {
                    case "1":
                        AddProduct(ref products);
                        break;
                    case "2":
                        ListProducts(ref products);
                        break;
                    case "3":

                        Console.Clear();
                        WriteTitle("Ürün Güncelleme");

                        Console.Write("Lütfen düzeltmek istediğiniz ürün numarasını giriniz : ");
                        int index = int.Parse(Console.ReadLine()) - 1;

                        Console.Write("Lütfen yeni değeri giriniz : ");
                        string newValue = Console.ReadLine();

                        products[index] = newValue;

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Güncelleme işlemi yapılmıştır.");
                        Console.ResetColor();
            
                        Console.WriteLine();
                        Console.WriteLine("Lütfen devam etmek için bir tuşa basınız...");
                        Console.ReadKey();

                        break;
                    case "4":
                        break;
                    case "0":
                        break;

                    default:
                        break;
                }

            } while (islem != "0");
        }


        static void AddProduct(ref string[] products)
        {
            Console.Clear();
            WriteTitle("Ürün Ekleme");

            Console.WriteLine("NOT : Ürün ekleme işlemini bitirmek için değer girmeden ENTER tuşuna basınız.");
            Console.WriteLine();

            int i = 0;
            string deger;

            do
            {
                Console.Write((i + 1) + ". Ürün : ");
                deger = Console.ReadLine();

                if (deger == "")
                    break;

                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = deger;
                i++;

            } while (deger != "");
        }

        static void ListProducts(ref string[] products)
        {
            Console.Clear();
            WriteTitle("Ürün Listeleme");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine((i + 1) + ". Ürün : " + products[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Lütfen devam etmek için bir tuşa basınız...");
            Console.ReadKey();
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
    }
}