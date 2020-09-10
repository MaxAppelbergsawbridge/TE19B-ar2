using System;

namespace uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double längd = 0;
            double längdVärldsrekord = 2.45;
            string meddelande = "";
            double skillnaden = 0;
            Console.WriteLine("Hur högt kan du hoppa?");
            //läsa hur högt användaren kan hoppa
            längd = double.Parse(Console.ReadLine());
            //beräkna skillnaden
            skillnaden = längdVärldsrekord - längd;
            meddelande = "du är" + skillnaden + "ifrån världsrekorden";
            Console.WriteLine(meddelande);
        }
    }
}
