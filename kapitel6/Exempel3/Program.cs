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
        /// <summary>
        /// summerar två tal 
        /// </summary>
        /// <param name="x"> tal 1</param>
        /// <param name="y"> tal 2 </param>
        /// <returns> summan av två tal</returns>
        static int summera(int x, int y)
        {
            int z = x + y;
            return z;
        }
    }
}
