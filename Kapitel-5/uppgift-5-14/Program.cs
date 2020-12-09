using System;

namespace uppgift_5_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frågor = { "hur många frågor finns det i den här quiz?", "hur många svar finns det i den här quiz?", "Vilken fråga är det här?", "3+1" };
            string[] svar = { "4", "4", "3", "4" };
            Console.WriteLine("Det finns 4 olika frågor vilken vill du svara på?(svara i siffror)");
            int tal = int.Parse(Console.ReadLine());
            tal++;
            Console.WriteLine(frågor[tal]);
            string användarensSvar = Console.ReadLine();
            if (användarensSvar == svar[tal])
            {
                Console.WriteLine("rätt svar!");
            }
            else
            {
                Console.WriteLine("fel svar!");
            }
        }
    }
}
