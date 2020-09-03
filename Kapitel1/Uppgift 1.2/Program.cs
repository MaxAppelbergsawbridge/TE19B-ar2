/*
Ett Program som skriver fler rad kod
*/
using System;

namespace Uppgift_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta är ett program gjort i C#.");
            Console.WriteLine("Programmet skriver ut text på flera rader.");
            Console.WriteLine("Detta är programmets sista utskrift.");
            // smidigare sätt att göra
            Console.WriteLine("Detta är ett program gjort i C#.\n" +
            "Programmet skriver ut\t text på flera rader.\n" +
            "Detta \"är programmets\\ sista utskrift.\n");
        }
    }
}
