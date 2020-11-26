using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //be om en text
            Console.WriteLine("Ange en text");
            string svar = Console.ReadLine();
            //Dela texten i separata ord
            string[] orden = svar.Split(' ');
            //loopa genom arrayen
            for (int i = 0; i < orden.Length; i++)
            {
                Console.WriteLine($"ord {i + 1}: {orden[i]}");
            }
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }
        }
    }
}
