using System;

namespace Uppgift6._21
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(potenser(5));
            System.Console.WriteLine(potenser(5.5));
        }
        static int potenser(int tal)
        {
            int svar = tal * tal;
            return svar;
        }
        static double potenser(double decimaltal)
        {
            double svar = decimaltal * decimaltal;
            return decimaltal;
        }
    }
}
