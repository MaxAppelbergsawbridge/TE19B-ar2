using System;

namespace uppgift_5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = { "Det är nio dagar kvar till jullov.", "Idag är den nionde av December", "Jag är hemma" };
            for (int i = 0; i < meningar.Length; i++)
            {
                System.Console.WriteLine(meningar[i]);
                System.Console.WriteLine(" ");
            }
        }
    }
}
