namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());

            switch (sayi)
            {
                case 10:
                    Console.WriteLine("Sayı 10 dur.");
                    break;

                case 20:
                    Console.WriteLine("Sayı 20 dir.");
                    break;

                case 30:
                    Console.WriteLine("Sayı 30 dur.");
                    break;

                case 40:
                case 50:
                case 60:
                    Console.WriteLine("Sayı 4 ya da 5 ya da 6 dır.");
                    break;

                default:
                    Console.WriteLine("Sayı " + sayi + " dir.");
                    break;
            }
        }
    }
}
