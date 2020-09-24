using System;

namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur lång är du");
            double längd = double.Parse(Console.ReadLine());
            if (längd > 1.5 && längd < 1.9)
            {
                Console.WriteLine("du får åka");
            }
            else
            {
                Console.WriteLine("Du får inte åka");
            }
        }
    }
}
