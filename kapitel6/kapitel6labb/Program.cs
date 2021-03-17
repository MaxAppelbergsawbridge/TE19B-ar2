using System;

namespace kapitel6labb
{
    class Program
    {
        static void Main(string[] args)
        {

            string text1 = "Metoder!";
            string text2 = "upprepning";
            string text3 = "upprepning2";
            textUtskrivning(text1);
            textUtskrivning(text2);
            textUtskrivning(text3);
        }
        static void textUtskrivning(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                System.Console.WriteLine(text[i]);
            }
        }
    }
}
