using System;

namespace Prov3a
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flagga=true;
            System.Console.WriteLine("Ange din ålder i jordår");
            //Sparar jordÅr så den kan användas senare
            double jordÅr=ReadDouble();
            //while loop
            while(flagga==true){
            //Switch så programmet delar jordår med rätt värde(mars,neptunus).Skrivmeny, skriver ut menyvalet och ger svar
            switch (SkrivMeny())
            {
                case"1":
                System.Console.WriteLine( jordÅr/0.2408467);
                break;
                case"2":
                System.Console.WriteLine(jordÅr/0.61519726);
                break;
                case"3":
                System.Console.WriteLine(jordÅr/1.8808158);
                break;
                case"4":
                System.Console.WriteLine(jordÅr/11.862615);
                break;
                case"5":
                System.Console.WriteLine(jordÅr/29.447498);
                break;
                case"6":
                System.Console.WriteLine(jordÅr/84.016846);
                break;
                case"7":
                System.Console.WriteLine(jordÅr/164.79132);
                break;
                case "8":
                flagga=false;
                break;
                default:
                break;
            }
           }
        }
        /// <summary>
        /// Skriver ut meny 
        /// </summary>
        /// <returns>val som en string</returns>
        static string SkrivMeny()
        {
        System.Console.WriteLine("Välj ett alternativ");
        Console.ForegroundColor = ConsoleColor.Gray;
        System.Console.WriteLine("1.Räkna ut ålder på Mercurius");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine("2.Räkna ut ålder på Venus");
        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("3. Räkna ut ålder på Mars");
        Console.ForegroundColor = ConsoleColor.White;
        System.Console.WriteLine("4. Räkna ut ålder på Jupiter");
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.WriteLine("5. Räkna ut ålder på Saturnus");
        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.WriteLine("6. Räkna ut ålder på Uranus");
        Console.ForegroundColor =ConsoleColor.DarkBlue;
        System.Console.WriteLine("7. Räkna ut ålder på Neptunus");
        System.Console.WriteLine("8. Avsluta");
        string svar=Console.ReadLine();
        return svar;
        }
         /// <summary>
        /// Läser in decimaltal
        /// </summary>
        /// <returns> double</returns>
        static double ReadDouble()
        {
            double svar = 0.0;
            while (!double.TryParse(Console.ReadLine(), out svar))
            {
                System.Console.WriteLine("Ange en giltig decimaltal");
            }
            return svar;
        }
    }
}