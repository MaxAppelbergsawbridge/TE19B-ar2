using System;

namespace uppgift_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] årtalen = { 2000, 2000, 2001, 2002, 2003 };
            Console.WriteLine("skriv in ett årtal");
            int svar = int.Parse(Console.ReadLine());
            bool flagga = false;
            for (int i = 0; i < årtalen.Length; i++)
            {
                if (svar == årtalen[i])
                {
                    Console.WriteLine($"årtalen {svar} hittades på index{i}");
                    flagga = true;
                }
                if (!flagga)
                {

                    Console.WriteLine($"årtalen{svar} hittades inte");
                }
            }
        }
    }
}
