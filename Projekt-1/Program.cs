using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in spelarens svar
            Console.WriteLine("Skriv produkten av mängden av bokstäver i ditt namn gånger ett tal  mellan 1-6");
            int svar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Låt mig gissa hur långt ditt namn är");
            //gissa vad spelaren har gjort
            //om spelaren gångrade med 1
            Console.WriteLine("gångrade du med 1?");
            string svar2 = Console.ReadLine();
            svar2 = svar2.ToLower();
            if (svar2 == "ja")
            {
                int final = svar1 / 1;
                Console.WriteLine("Är ditt numner" + final + "?");
            }
            else
            {
                Console.WriteLine("nästa tal");

            }
            //om spelaren gångrade med 2
            Console.WriteLine("är ditt numner 2?");
            string svar3 = Console.ReadLine();
            svar3 = svar3.ToLower();
            if (svar3 == "ja")
            {
                int final = svar1 / 2;
                Console.WriteLine("Är ditt numner" + final + "?");
            }
            else
            {
                Console.WriteLine("nästa tal");

            }
            //om spelaren gångrade med 3
            Console.WriteLine("är ditt numner 3?");
            string svar4 = Console.ReadLine();
            svar4 = svar4.ToLower();
            if (svar4 == "ja")
            {
                int final = svar1 / 3;
                Console.WriteLine("Är ditt numner" + final + "?");
            }
            else
            {
                Console.WriteLine("nästa tal");

            }
            //om spelaren gångrade med 4
            Console.WriteLine("är ditt numner 4?");
            string svar5 = Console.ReadLine();
            svar5 = svar5.ToLower();
            if (svar5 == "ja")
            {
                int final = svar1 / 4;
                Console.WriteLine("Är ditt numner" + final + "?");
            }
            else
            {
                Console.WriteLine("nästa tal?");

            }
            //om spelaren gångrade med 5
            Console.WriteLine("är ditt numner 5?");
            string svar6 = Console.ReadLine();
            svar6 = svar6.ToLower();
            if (svar6 == "ja")
            {
                int final = svar1 / 5;
                Console.WriteLine("Är ditt numner" + final + "?");
            }
            else
            {
                Console.WriteLine("nästa tal?");

            }
            //om spelaren gångrade med 6
            Console.WriteLine("är ditt numner 6?");
            string svar7 = Console.ReadLine();
            svar7 = svar7.ToLower();
            if (svar7 == "ja")
            {
                int final = svar1 / 6;
                Console.WriteLine("Är ditt numner" + final + "?");
            }
            else
            {
                Console.WriteLine("HUR ÄR DET MÖJLIGT DU SKULLE BARA GÅNGRA MED TAL MELLAN 1-6");

            }
        }
    }

}
