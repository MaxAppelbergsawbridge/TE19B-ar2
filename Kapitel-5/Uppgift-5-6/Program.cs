using System;

namespace Uppgift_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] svar = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv in en stad");
                svar[i] = Console.ReadLine();

            }
            foreach (var ord in svar)
            {
                Console.WriteLine(ord);
            }
        }
    }
}
