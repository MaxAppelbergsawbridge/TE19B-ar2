using System;

namespace Uppgift_4_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string svar = "";
            while (svar != "stockholm")
            {
                Console.WriteLine("Vad heter Sveriges huvudstad?");
                svar = Console.ReadLine();
                svar = svar.ToLower();
            }

        }
    }
}
