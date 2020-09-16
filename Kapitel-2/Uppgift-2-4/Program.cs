using System;

namespace Uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läs in första argumentet
            Console.WriteLine("Välj 1 tal");
            int a = int.Parse(args[0]);
            Console.WriteLine("Välj 1 till tal");
            int b = int.Parse(args[1]);
            int c = a + b;
            Console.WriteLine("summa är" + c);
        }
    }
}
