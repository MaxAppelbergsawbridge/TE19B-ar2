using System;

namespace Uppgift_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vem vann vm för damer 2015?");
            string svar = Console.ReadLine();
            svar = svar.ToLower();
            if (svar == "usa")
            {
                Console.WriteLine("Rätt");
            }
            else
            {
                Console.WriteLine("fel");
            }

        }
    }
}
