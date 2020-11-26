using System;

namespace uppgift_5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv en mening");
            string mening = Console.ReadLine();
            string[] ord = mening.Split(' ');
            for (int i = 0; i < ord.Length; i++)
            {
                Console.Write();
            }
        }
    }
}
