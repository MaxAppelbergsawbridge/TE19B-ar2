using System;

namespace Uppgift_6._16
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivVertikalt("hej", 2);
        }
        static void SkrivVertikalt(string meddelande, int AntalTommaRader = 0)
        {
            for (int i = 0; i < meddelande.Length; i++)
            {
                System.Console.WriteLine(meddelande[i]);
                for (int z = 0; z < AntalTommaRader; z++)
                {
                    System.Console.WriteLine();
                }
            }
        }
    }
}

