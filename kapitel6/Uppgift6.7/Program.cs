using System;

namespace Uppgift6._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string flestbokstäver = längst("hej", "hejsan");
            Console.WriteLine(flestbokstäver);
        }
        static string längst(string text1, string text2)
        {
            int antalord1 = text1.Length;
            int antalord2 = text2.Length;
            if (antalord1 > antalord2)
            {
                return text1;
            }
            else
            {
                return text2;
            }
        }
    }
}
