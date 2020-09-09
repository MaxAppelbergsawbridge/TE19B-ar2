using System;

namespace Konsolen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändra bakgrunds färg på terminalen
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            //Ändra textfärg på bakgrunden 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");
        }
    }
}
