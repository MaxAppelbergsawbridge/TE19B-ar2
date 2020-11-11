using System;

namespace tärningsimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hur många tärningar vill du kasta?");
            int tärningar = 0;
            string svar1 = Console.ReadLine();
            while (!int.TryParse(svar1, out tärningar))
            {
                Console.WriteLine("Försök igen");
                svar1 = Console.ReadLine();
            }
            Console.WriteLine("och hur många sidor ska alla ha?");
            int sida = 0;
            string svar2 = Console.ReadLine();
            while (!int.TryParse(svar2, out sida))
            {
                Console.WriteLine("Försök igen");
                svar1 = Console.ReadLine();
            }
            Random Slumptal = new Random();
            for (int i = 0; i < tärningar; i++)
            {
                int tärning = Slumptal.Next(1, sida + 1);
                Console.WriteLine(tärning);
            }
        }
    }
}
