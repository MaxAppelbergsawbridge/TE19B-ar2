using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //slumpa fram ett tal
            Random tärning = new Random();
            int slumptal = tärning.Next(1, 7);


            while (true)
            {
                //be användaren att gissa och läs in 
                Console.WriteLine("Gissa ett tal (1-6)");
                int gissning = int.Parse(Console.ReadLine());

                // Om användaren får rätt 
                if (gissning == slumptal)
                {
                    Console.WriteLine("Rätt gissat!");
                    break;
                }
                else
                {
                    Console.WriteLine("Fel gissat!Försök igen");
                }
            }
            //slut
            Console.WriteLine("Tack för idag");

        }
    }
}
