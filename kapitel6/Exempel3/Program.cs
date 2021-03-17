using System;

namespace Exempel3
{
    class Program
    {
        static void Main(string[] args)
        {

            int summa = summera(99, 123);
            System.Console.WriteLine(summa);
        }
        static int summera(int x, int y)
        {
            int z = x + y;
            return z;
        }
    }
}
