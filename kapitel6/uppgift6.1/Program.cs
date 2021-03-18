using System;

namespace uppgift6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            upphöjdTilltvå(5);
            upphöjdTilltvå(2);
            upphöjdTilltvå(10);
        }
        /// <summary>
        /// Upphöjer tal till två och skriver ut resultatet
        /// </summary>
        /// <param name="tal"></param>
        static void upphöjdTilltvå(int tal)
        {
            int svar = tal * tal;
            System.Console.WriteLine(svar);
        }
    }
}
