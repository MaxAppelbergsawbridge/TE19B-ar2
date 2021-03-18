using System;

namespace ReadIntTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ange ett numner 1-100");
            Readint();
            System.Console.WriteLine($"");
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
