using System;

namespace uppgift_5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hur många tal vill du skriva in?");
            int mängd = int.Parse(Console.ReadLine());
            int[] tal = new int[mängd];
            System.Console.WriteLine("skriv in" + mängd + "heltal");
            for (int i = 0; i < mängd; i++)
            {
                tal[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < mängd; i++)
            {
                System.Console.WriteLine("Tal" + (i + 1) + ":" + tal[i]);
            }
        }
    }
}
