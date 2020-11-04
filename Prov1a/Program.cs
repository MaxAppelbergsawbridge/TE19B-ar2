using System;

namespace Prov1a
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarera variabler

            int lön = 0;
            string svar = "ja";
            svar = svar.ToLower();
            //förklaring av programmet 
            Console.WriteLine("Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.");
            Console.WriteLine("Marginalskatten räknas ut baserat på din bruttolön.");
            Console.WriteLine("Med bruttolön avses din årslön före skatt.");
            //val
            while (svar == "ja")
            {
                //inläsning
                Console.WriteLine("Ange din bruttolön i kr");
                if (!int.TryParse(Console.ReadLine(), out lön))
                {
                    Console.WriteLine("Ange ett tal");

                }
                else if (lön <= 0)
                {
                    Console.WriteLine("Ange ett tal som är större än noll!");
                }
                //beräkning
                else if (lön < 10000)
                {
                    lön = lön * 92;
                    lön = lön / 100;
                    Console.WriteLine("Din lön är " + lön);

                }
                else if (lön > 10000 || lön > 145000)
                {
                    lön = lön * 78;
                    lön = lön / 100;
                    Console.WriteLine("Din lön är " + lön);

                }
                else if (lön > 145000 || lön < 515000)
                {
                    lön = lön * 67;
                    lön = lön / 100;
                    Console.WriteLine("Din lön är " + lön);

                }
                else if (lön > 515000)
                {
                    lön = lön * 47;
                    lön = lön / 100;
                    Console.WriteLine("Din lön är " + lön);

                }//frågar om användaren vill köra om 
                Console.WriteLine("Vill du göra en ny beräkning?");
                svar = Console.ReadLine();
            }


        }
    }
}

