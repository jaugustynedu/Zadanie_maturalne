using System;

namespace ConsoleApp1
{
    class Program
    {
        static string prime_numbers(int x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return x+" jest liczbą pierwszą";
                }
            }
            return x + " nie jest liczbą pierwszą"; ;
            

        }

        static void Main(string[] args)
        {
            prime_numbers(8);
           /*
            Random r = new Random();
            int random = r.Next(0, 10);
            Console.WriteLine("Wybierz liczbe od 0 do 10: ");
            int x = -1;
            
            while (x!=random)
            {
                Console.WriteLine("Podaj liczbe!");
                x = Convert.ToInt32(Console.ReadLine());
                if (x == random)
                {
                    Console.WriteLine("Brawo!");
                }
                else
                {
                    Console.WriteLine("Spróbuj ponownie");
                }
            }
            

            int[] numbers = { 1,4,10,16 };

            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
           */

        }
    }
}
