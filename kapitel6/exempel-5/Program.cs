using System;

namespace exempel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //använder den första metoden
            SkrivVertikalt("hej");
            //använder den andra metoden
            SkrivVertikalt(12);
        }
        static void SkrivVertikalt(string meddelande)
        {
            for (int i = 0; i < meddelande.Length; i++)
            {
                System.Console.WriteLine(meddelande[i]);
            }
        }
        static void SkrivVertikalt(int tal)
        {
            SkrivVertikalt(tal.ToString());
        }
    }
}
