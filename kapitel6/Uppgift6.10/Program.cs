using System;

namespace Kapitel6._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv någonting");
            HelTal();
        }
        static void HelTal()
        {
            int svar=0;
            if(!int.TryParse(Console.ReadLine(),out svar))
            {
                System.Console.WriteLine("Detta är inte ett heltal");
            }else
            {
                System.Console.WriteLine("Detta är ett heltal");
            }
        } 
    }
}
