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
        static void upphöjdTilltvå(int tal)
        {
            int svar = tal * tal;
            System.Console.WriteLine(svar);
        }
    }
}
