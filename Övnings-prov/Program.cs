using System;

namespace Övnings_prov
{
    class Program
    {
        static void Main(string[] args)
        {
            //x*6=42
            int rättsvar = 0;
            int svar = 0;
            Random numner = new Random();
            int a = numner.Next(1, 9);
            int b = numner.Next(1, 9);
            Console.WriteLine("x*" + b + "=" + a * b);
            Console.WriteLine("Vad ska x vara?");
            bool kör = true;
            while (kör == true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out svar))
                {
                    if (svar == a)
                    {
                        Console.WriteLine("Bra jobbat");
                        rättsvar++;
                        kör = false;
                    }
                    else
                    {
                        Console.WriteLine("nej" + svar + "*" + b + "=" + svar * b);
                        kör = false;
                    }
                }
                else
                {
                    Console.WriteLine("Skriv ett tal tack");
                }
            }
            Console.WriteLine(rättsvar + "frågor rätt");
            /*a1*a2
            svar=a1 
            a2=6 
            */
        }
    }
}
