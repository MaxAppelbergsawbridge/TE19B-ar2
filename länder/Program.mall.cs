using System;
using System.IO;

namespace Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Presentera programmet
            System.Console.WriteLine("Det här programmet låter dig söka efter länder i ett csv fil");
            // Fråga användare om en sökterm
            if (File.Exists("countries.csv"))
            {
                System.Console.WriteLine("Ange två bokstäver ");
                string svar = Console.ReadLine();
                // Sökning fungerar oavsett stora eller små bokstäver se https://krank23.gitbook.io/csharp-ref/grundlaeggande/string-manipulering
                svar = svar.ToLower();
                string[] rader = File.ReadAllLines("countries.csv");
                // Avbryt programloop användaren matat in tomt dvs return

                // Loopa igenom alla rader
                foreach (var rad in rader)
                {
                    // Dela upp raden
                    string[] data = rad.Split(',');
                    // Hitta land som innehåller sökterm se https://www.geeksforgeeks.org/c-sharp-string-contains-method/
                    if (data[2] == svar)
                    {
                        System.Console.WriteLine(data[1]);
                    }
                }
            }
        }
    }
}


