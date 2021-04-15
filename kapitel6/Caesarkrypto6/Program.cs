using System;

namespace Caesarkrypto6
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("ange en text att kryptera");
            string meddelande = Console.ReadLine();
            System.Console.WriteLine($"Krypterat med ett steg:{CaesarKryptera(meddelande)}");
            System.Console.WriteLine($"Krypterat med tre steg:{CaesarKryptera(meddelande, 3)}");
        }
        /// <summary>
        /// krypterar text genom att flytta alla tecken en steg åt höger
        /// </summary>
        /// <param name="text"></param>
        /// <param name="nyckel"></param>
        /// <returns> krypterat text</returns>
        static string CaesarKryptera(string text, int nyckel = 1)
        {
            string textkrypterat = "";
            for (int i = 0; i < text.Length; i++)
            {
                //plocka ut tecken 
                char tecken = text[i];
                //ta reda tecken koden
                int teckenkod = (int)tecken;
                //Räkna ut krypterat tecken
                int teckenKodKrypterat = teckenkod + nyckel;
                //tillbaka till tecken
                char teckenKrypterat = (char)teckenKodKrypterat;
                //sätt tillsamma tecken
                textkrypterat += teckenKrypterat;
            }
            return textkrypterat;
        }
    }
}
