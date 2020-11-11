using System;

namespace lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            // be användaren om ett tal
            Console.WriteLine("Gissa vilken tal markören kommer stanna på");
            string svar = Console.ReadLine();
            int intsvar = 0;
            while (!int.TryParse(svar, out intsvar))
            {
                Console.Write("Skriv in ett numner");
                Console.ReadLine();
            }
            //slumpa fram ett tal
            Random slumptal = new Random();
            int lyckohjul = slumptal.Next(1, 11);
            //berätta för användaren vad slumptalet blev
            Console.Write($"talet var" + lyckohjul);
            if (lyckohjul == intsvar)
            {
                Console.Write("Du hade rätt");
            }
            else
            {
                Console.Write("Du hade fel");
            }
        }
    }
}
