using System;

namespace Uppgift6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double multiplikation = Multiplicera(5, 5);
            double division = Dividera(5, 5);
            System.Console.WriteLine(multiplikation);
            System.Console.WriteLine(division);
        }
        static double Multiplicera(double tal1, double tal2)
        {
            double tal3 = tal1 * tal2;
            return tal3;
        }
        static double Dividera(double tal1, double tal2)
        {
            double tal3 = tal1 / tal2;
            return tal3;
        }
    }
}
