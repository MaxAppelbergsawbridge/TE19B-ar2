using System;

namespace Uppgift_4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många kvadrat tal vill du se?");
            int mängdKvadrattal = int.Parse(Console.ReadLine());
            for (int i = 1; i <= mängdKvadrattal; i++)
            {
                int kvadrat = i * i;
                Console.WriteLine(kvadrat);
            }
        }
    }
}
