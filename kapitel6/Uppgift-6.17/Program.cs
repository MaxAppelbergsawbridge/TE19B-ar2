using System;

namespace Uppgift_6._17
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("hej", 2, 3);
            System.Console.WriteLine();
        }
        static void SkrivVertikalt(string meddelande, int AntalTommaRader = 0, int StegÅtHöger = 0)
        {
            for (int i = 0; i < meddelande.Length; i++)
            {
                for (int z = 0; z < AntalTommaRader; z++)
                {
                    System.Console.WriteLine();
                }
                for (int j = 0; j < StegÅtHöger; j++)
                {
                    Console.Write(" ");
                }
                System.Console.WriteLine(meddelande[i]);
            }
        }
    }
}
