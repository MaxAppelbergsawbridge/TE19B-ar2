using System;

namespace uppgift_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många sporter har du testat?");
            int mängd = int.Parse(Console.ReadLine());
            string[] sporter = new string[mängd];
            for (int i = 0; i < mängd; i++)
            {
                Console.WriteLine("skriv in en sport");
                sporter[i] = Console.ReadLine();
            }
            for (int i = 0; i < mängd; i++)
            {
                Console.WriteLine(sporter[i]);
            }
        }
    }
}
