using System;

namespace Uppgift_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (ålder >= 65 || (ålder >= 10 && ålder <= 18))
            {
                Console.Write("du får billigare kaffe");
            }
            else
            {
                Console.Write("Tyvärr så får du inte billigare kaffe");
            }
        }
    }
}
