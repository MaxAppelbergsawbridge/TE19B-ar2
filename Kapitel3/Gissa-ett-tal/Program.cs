using System;

namespace Gissa_ett_tal
{
    class Program
    {
        static void Main(string[] args)
        {

            //fråga 5 gånger
            for (int i = 0; i < 5; i++)
            {
                //Slumpa fram ett tal
                Random random = new Random();
                int slumptal = random.Next(7);
                //läs in gissning
                Console.WriteLine("Gissa ett tal (1-6)?");
                int gissning = int.Parse(Console.ReadLine());
                //Kolla om gissningen är korrekt 
                if (gissning == slumptal)
                {
                    Console.WriteLine("Rätt svar!");
                    i = 5;
                }
                else
                {
                    Console.WriteLine("Fel svar!");
                }
            }
        }
    }
}
