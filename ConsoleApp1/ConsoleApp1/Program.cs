using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();
            int random = r.Next(0, 10);
            Console.WriteLine("Wybierz liczbe od 0 do 10: ");
            int x = Int32.Parse(Console.ReadLine());

            if (x == random){
                Console.WriteLine("Zgadłeś, brawo!");
            }
            else {
                Console.WriteLine("Nie udało się. Wylosowana liczba to: "+random);
            }




        }
    }
}
