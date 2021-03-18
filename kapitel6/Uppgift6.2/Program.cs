using System;

namespace kapitel6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            skrivBaklänges("hej");
            skrivBaklänges("skrivbaklänges");
            skrivBaklänges("boom");
        }
        /// <summary>
        /// Skriver ut ord baklänges
        /// </summary>
        /// <param name="meddelande"> den angett ord</param>
        static void skrivBaklänges(string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                System.Console.WriteLine(meddelande[i]);
            }
        }
    }
}
