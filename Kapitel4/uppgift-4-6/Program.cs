using System;

namespace uppgift_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in meddelande");
            string meddelande = Console.ReadLine();
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        }
    }
}
