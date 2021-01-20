using System;
using System.IO;

namespace Filhantering2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string filnamn = "./animals.txt";
            string[] rader = File.ReadAllLines(filnamn);
            System.Console.WriteLine("vad vill du söka efter?");
            string sök = Console.ReadLine();
            foreach (var item in collection)
            {
                if (rad.substring(0, 1) == sök)
                {
                    System.Console.WriteLine(rader[i]);
                }
                i++;
            }
            System.Console.WriteLine($"hittade{i} djur");
        }
    }
}
