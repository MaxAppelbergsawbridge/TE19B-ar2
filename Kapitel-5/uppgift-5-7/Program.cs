using System;

namespace uppgift_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarera int
            int summa = 0;
            int[] tal = { 5, 5, 5, 5, 5 };
            //skriv in 5 tal
            foreach (var numner in tal)
            {
                summa += numner;
            }
            Console.WriteLine(summa);
        }
    }
}
