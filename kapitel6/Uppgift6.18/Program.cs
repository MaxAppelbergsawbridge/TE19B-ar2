using System;

namespace Uppgift6._18
{
    class Program
    {
        static string[] tal = { "tal1", "tal2", "tal3" };
        static void Main(string[] args)
        {
            System.Console.WriteLine("Vilka tal vill du addera?");
            Readint();
            Addera();
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            int svar = tal1 + tal2 + tal3;
            return summa;
        }
        /// <summary>
        /// Läser in tal på ett säkert sätt
        /// </summary>
        /// <returns> ger tal</returns>
        static int Readint()
        {
            int svar = 0;
            while (!int.TryParse(Console.ReadLine(), out svar))
            {
                System.Console.WriteLine("inte ett giltig numner");
            }
            return svar;
        }
    }
}
}
