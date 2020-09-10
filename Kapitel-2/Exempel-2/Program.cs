using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarera några variabler
            string namn = "";
            int ålder = 0;
            int ålderÅr2025 = 0;//camelcase
            string meddelande = "";
            double längd = 0;
            //namn
            Console.Write("Vad heter du?");
            namn = Console.ReadLine();
            //längd
            Console.Write("Hur lång är du?");
            längd = double.Parse(Console.ReadLine());
            //ålder 2020+5= åder 2025
            Console.Write("Hur gammal är du?");
            ålder = int.Parse(Console.ReadLine());
            ålderÅr2025 = ålder + 5;
            meddelande = " Hej! " + namn + " du är " + längd + "lång" + ålderÅr2025 + " år gammal om 2025 ";
            Console.Write(meddelande);
        }
    }
}
