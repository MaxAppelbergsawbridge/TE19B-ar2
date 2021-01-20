using System;
using System.IO;
namespace Filhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("provFil.txt", "Nu snöar det igen");
            string allText = File.ReadAllText("./provFil.txt");
            System.Console.WriteLine($"Innehållet är:\n{allText}");
            System.Console.Write("ange en filnamn:");
            string filnamn = Console.ReadLine();
            if (File.Exists(filnamn))
            {
                string texten = File.ReadAllText(filnamn);
                System.Console.WriteLine(texten);
            }
            else
            {
                System.Console.WriteLine($"filen\"{filnamn}\"finns inte");
            }
        }
    }
}
