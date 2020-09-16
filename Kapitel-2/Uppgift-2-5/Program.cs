using System;

namespace Uppgift_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket år är det?");
            int år = int.Parse(Console.ReadLine());
            int tidTill2100 = 2100 - år;
            Console.WriteLine("Det är " + tidTill2100 + "år tills år2100");
        }
    }
}
