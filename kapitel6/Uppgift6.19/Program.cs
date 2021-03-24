using System;

namespace Uppgift6._19
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Jämför två tal");
            System.Console.WriteLine(störst(Readint(), Readint()));
        }
        static int störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
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
