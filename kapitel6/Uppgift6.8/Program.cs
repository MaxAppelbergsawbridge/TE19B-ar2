using System;

namespace Uppgift6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int antalChar = AntalISträng('m', "Välkommen");
            System.Console.WriteLine(antalChar);
        }
        static int AntalISträng(char tecken, string text)
        {
            int antalLoopar = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (tecken == text[i])
                {
                    antalLoopar = antalLoopar + 1;
                }
            }
            return antalLoopar;
        }
    }
}
