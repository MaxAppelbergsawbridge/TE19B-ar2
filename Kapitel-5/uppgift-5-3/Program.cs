using System;

namespace uppgift_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heltalen = { 9, 4, 7, 8, 3, 2, 9, 5 };
            //skapa en variable max
            int max = 0;
            for (int i = 0; i < heltalen.Length; i++)
            {
                if (max < heltalen[i])
                {
                    max = heltalen[i];
                }
            }
            Console.WriteLine($"Största talet är{max}");
        }
    }
}
