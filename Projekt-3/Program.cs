using System;

namespace Projekt_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //highscore
            int antaletRätt = 0;
            //namn
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            //fråge bank
            string frågaett = "Vilket är a?";
            //quizmachine
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    string rättsvar = "3";
                    Console.WriteLine("fråga1 Vart är c?");
                    Console.WriteLine("1.c");
                    Console.WriteLine("2.b");
                    Console.WriteLine("3.a");
                    string svar = Console.ReadLine();
                    if (svar == rättsvar)
                    {
                        Console.WriteLine("bra jobbat");
                        antaletRätt++;
                    }
                }


                if (i == 1)
                {
                    string rättsvar = "1";
                    Console.WriteLine("fråga2:vart är c?");
                    Console.WriteLine("1.c");
                    Console.WriteLine("2.b");
                    Console.WriteLine("3.a");
                    string svar = Console.ReadLine();
                    if (svar == rättsvar)
                    {
                        Console.WriteLine("bra jobbat");
                        antaletRätt++;
                    }

                }
                if (i == 2)
                {
                    string rättsvar = "2";
                    Console.WriteLine("fråga2: Vart är b?");
                    Console.WriteLine("1.c");
                    Console.WriteLine("2.b");
                    Console.WriteLine("3.a");
                    string svar = Console.ReadLine();
                    if (svar == rättsvar)
                    {
                        Console.WriteLine("bra jobbat");
                        antaletRätt++;
                    }
                }

            }
            Console.WriteLine("vill du spela om?");
            string slutsvar = Console.ReadLine();
            slutsvar = slutsvar.ToLower();
            if (slutsvar == "ja")
            {
                int i = 0;
                Console.WriteLine(antaletRätt);
            }
            Console.WriteLine(antaletRätt);
            Console.WriteLine("Tack för att du spelade!");

        }
    }
}
