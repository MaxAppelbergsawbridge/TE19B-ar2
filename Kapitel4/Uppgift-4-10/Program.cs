using System;

namespace Uppgift_4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-30
            for (int i = 0; i < 30; i++)
            {
                int svar = i % 4;
                if (svar == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
