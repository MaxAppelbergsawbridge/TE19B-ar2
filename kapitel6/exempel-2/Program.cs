using System;

namespace exmepel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = "1";
            meny();
            svar = Console.ReadLine();
            while (svar != "3")
            {

                switch (svar)
                {
                    case "1":
                        skrivUtvertikalt();
                        break;
                    case "2":
                        skrivUtomvänt();
                        break;
                    case "3":
                        break;
                    default:
                        break;
                }
            }

        }
        static void meny()
        {
            Console.WriteLine("Välj en alternativ");
            System.Console.WriteLine("1.Skriv ut texten vertikalt");
            System.Console.WriteLine("2.Skriv ut texten omvänt");
            System.Console.WriteLine("3.avsluta");
        }
        static void skrivUtvertikalt()
        {

        }
        static void skrivUtomvänt()
        {

        }
    }
}
