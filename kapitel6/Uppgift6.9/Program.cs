using System;

namespace Uppgift6._9
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ange ett decimaltal");
            ReadDouble();
        }
        static double ReadDouble()
        {
            double svar = 0.0;
            while (!double.TryParse(Console.ReadLine(), out svar))
            {
                System.Console.WriteLine("Ange en giltig decimaltal");
            }
            return svar;
        }
    }
}
