using System;

namespace Uppgift6._18
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Fråga();
                Readint(svar);
            }
            Addera();
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            int svar = tal1 + tal2 + tal3;
            return svar;
        }
        static string Fråga(string tal1, string tal2, string tal3)
        {
            string[] tal = { tal1, tal2, tal3 };
            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine($"skriv in ett tal[i]");
                tal[i] = Console.ReadLine();
                return tal[i];
            }
        }
        /// <summary>
        /// Metod som läser in int på ett säkert sätt.
        /// </summary>
        /// <returns> int</returns>
        static int Readint(string s)
        {
            int svar = 0;
            while (!int.TryParse(s, out svar))
            {
                System.Console.WriteLine("inte ett giltig numner");
            }
            return svar;
        }
    }
}
