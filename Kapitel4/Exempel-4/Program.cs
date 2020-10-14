using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // slumpa fram ett tal 
            Random slump = new Random();
            int slumptal = slump.Next(1, 7);
            //gissning
            int giss = 0;
            while (giss != slumptal)
            {
                Console.WriteLine("Gissa ett tal?");
                //giss = int.Parse(Console.ReadLine());
                // en säkrare inmattning
                string input = Console.ReadLine();
                //försöker översätta till ett heltal
                if (int.TryParse(input, out giss))
                {
                    Console.WriteLine("Vad bra");
                }
                else
                {
                    Console.WriteLine("Nej jag bad om ett tal, försök igen");
                }
                if (giss != slumptal)
                {
                    Console.WriteLine("Fel svar");
                }
            }

        }
    }
}
