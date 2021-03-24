using System;

namespace Uppgift6._20
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flagga = true;
            while (flagga == true)
            {
                Console.WriteLine("1.Addera tre tal\n2.Största talet\n3.avsluta programmet");
                string svar = Console.ReadLine();
                if (svar == "1")
                {
                    System.Console.WriteLine("vilka tal vill du addera?");
                    System.Console.WriteLine(MenyvalAddera(Readint(), Readint(), Readint()));
                }
                else if (svar == "2")
                {
                    System.Console.WriteLine("Vilka tal vll du jämföra?");
                    System.Console.WriteLine(MenyvalStörstaTalet(Readint(), Readint()));
                }
                else
                {
                    flagga = false;
                }
            }

        }
        static int MenyvalStörstaTalet(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
        }
        static int MenyvalAddera(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            return summa;
        }
        /// <summary>
        /// Läser in tal på ett säkert sätt
        /// </summary>
        /// <returns> ger tal</returns>
        static int Readint()
        {
            int svar = 0;
            while (!int.TryParse(Console.ReadLine(), out svar))
            {
                System.Console.WriteLine("inte ett giltig numner");
            }
            return svar;
        }
    }
}
