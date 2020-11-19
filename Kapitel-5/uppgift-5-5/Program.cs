using System;

namespace uppgift_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // programmet ska skriva in 100 åldrar
            int[] ålder = new int[100];
            //skriv in ett ålder
            Console.WriteLine("Skriv in ett ålder");
            ålder[0] = int.Parse(Console.ReadLine());

            //fråga användaren om hen vill skriva in flera ålder
            bool flagga = false;
            while (!flagga)
            {
                for (int i = 0; i < ålder.Length; i++)
                {
                    Console.WriteLine("Vill du skriva in ett ny ålder?j/n");
                    string svar = Console.ReadLine();
                    if (svar == "n")
                    {
                        flagga = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("skriv in ett ålder");
                        ålder[i] = int.Parse(Console.ReadLine());
                    }
                    if (i == 100)
                    {
                        Console.WriteLine("du har skrivit in 100 åldrar");
                        flagga = true;
                    }
                }
            }
            for (int i = 0; i < ålder.Length; i++)
            {
                Console.WriteLine($"du skrev in{ålder[i]}");
            }
        }
    }
}
