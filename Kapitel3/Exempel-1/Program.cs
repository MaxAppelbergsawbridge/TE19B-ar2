using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in ålder
            Console.WriteLine("Hur gammal är du? (svara i hela antal år)");
            int ålder = int.Parse(Console.ReadLine());
            //om 18 skriv myndig
            if (ålder >= 18)
            {
                Console.WriteLine("Du är myndig.Du får ta körkort");
            }
            if (ålder >= 15)
            {
                Console.WriteLine("Du får köra moped!");
            }
            if (ålder <= 15)
            {
                Console.WriteLine("Du får inte köra moped!");
            }
            Console.WriteLine("Vem var statsminister i Sverige 1970?");
            string statsminister = Console.ReadLine();
            if (statsminister == "Palme" || statsminister == "palme")
            {
                Console.WriteLine("rätt");
            }
            //sanera inmatning
            statsminister = statsminister.ToLower();
            if (statsminister == "palme")
            {
                Console.WriteLine("Rätt svar!");
            }
            else
            {
                Console.WriteLine("Fel svar!");
            }


        }
    }
}
