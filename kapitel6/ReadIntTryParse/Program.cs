using System;

namespace ReadIntTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("ange ett numner 1-100");
            Readint();
            System.Console.WriteLine($"");
        }
        static int Readint()
        {
            int svar = 0;
            while (!int.TryParse(console.ReadLine(), out svar))
            {
                System.Console.WriteLine("inte ett giltig numner");
            }
            return svar;
        }
    }
}
