using System;

namespace Uppgift_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = " ";
            while (option != "3")
            {
                Console.WriteLine("1.Omvandla meter till kilometer");
                Console.WriteLine("2.Omvandla kilometer till meter");
                Console.WriteLine("3.Avsluta");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Vad vill du omvandla till kilometer");
                        int meter = int.Parse(Console.ReadLine());
                        int kilometer = meter / 1000;
                        Console.WriteLine("det är " + kilometer + "km");
                        break;
                    case "2":
                        Console.WriteLine("Vad vill du omvandla till meter");
                        meter = int.Parse(Console.ReadLine());
                        kilometer = meter * 1000;
                        Console.WriteLine("det är" + meter + "m");
                        break;
                    default: break;
                }
            }


        }
    }
}
