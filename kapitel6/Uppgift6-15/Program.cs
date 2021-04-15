using System;

namespace Uppgift6_15
{
    class Program
    {
        static void Main(string[] args)
        {

            Skrivbaklänges("hej");
            Skrivbaklänges(51);
            Skrivbaklänges(0.3);
        }
        static void Skrivbaklänges(string meddelande)
        {
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                System.Console.Write(meddelande[i]);
            }
        }
        static void Skrivbaklänges(int tal)
        {
            Skrivbaklänges(tal.ToString());
        }
        static void Skrivbaklänges(double decimaltal)
        {
            Skrivbaklänges(decimaltal.ToString());
        }
    }
}
