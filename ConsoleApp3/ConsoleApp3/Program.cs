using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            switch (x)
            {
                case > 5:
                    Console.WriteLine("Liczba większa od 5");
                    break;
                case < 5:
                    Console.WriteLine("Liczba mniejsza od 5");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
}
