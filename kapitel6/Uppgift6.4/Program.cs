using System;

namespace Uppgift6._4
{
    class Program
    {
        static void Main(string[] args)//inte klar
        {
            Console.WriteLine("Hur stor ska rätvinklig triangeln vara?");
            int sidLängd = int.Parse(Console.ReadLine());
            //nestlade for loop
            RitaRätvinkligTriangel(sidLängd);

        }
        static void RitaRätvinkligTriangel(int x)
        {
            for (int i = 0; i < x; i++)
            {
                System.Console.WriteLine("*");
                for (int y = x; y > 0; y--)
                {
                    System.Console.WriteLine("*");
                }
            }
        }
    }
}
