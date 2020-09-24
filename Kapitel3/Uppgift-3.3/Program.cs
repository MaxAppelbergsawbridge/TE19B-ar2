using System;

namespace Uppgift_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad fick du för poäng?");
            int poäng = int.Parse(Console.ReadLine());
            if (poäng >= 55)
            {
                Console.WriteLine("du fick A");
            }
            else if (poäng >= 46)
            {
                Console.WriteLine("du fick B");
            }
            else if (poäng >= 35)
            {
                Console.WriteLine("du fick c");
            }
            else if (poäng >= 27)
            {
                Console.WriteLine(" du fick d");
            }
            else if (poäng >= 18)
            {
                Console.WriteLine("du fick e");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
