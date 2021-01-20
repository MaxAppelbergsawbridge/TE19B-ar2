using System;
using System.IO;
namespace bordhanterare
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skapa ett program där användaren får välja om hen vill skapa/skriva över en fil eller läsa in innehållet från en fil. Användaren ska därefter få skriva in namnet på filen.
             Om användaren valde att skapa/skriva över en fil ska hen sedan få skriva in en sträng som ska sparas i filen, om hen valde att läsa in innehållet från en fil ska filens innehåll visas. 
             Innan du läser in filen ska du undersöka om filen finns.*/
            System.Console.WriteLine("Vill du skapa eller läsa en fil?");
            string svar = Console.ReadLine();
            svar = svar.ToLower();
            if (svar == "skapa")
            {
                System.Console.WriteLine("Vad vill du kalla filen?");
                string namn = Console.ReadLine();
                System.Console.WriteLine("Vad vill du skriva i filen?");
                string fil = Console.ReadLine();
                if (File.Exists(namn))
                {
                    System.Console.WriteLine("Filen finns redan");
                }
                else
                {
                    File.WriteAllText(namn, fil);
                }

            }
            else if (svar == "läsa")
            {
                System.Console.WriteLine("Vilken fil vill du läsa?");
                string namn = Console.ReadLine();
                if (File.Exists(namn))
                {
                    string innehåll = File.ReadAllText(namn);
                    System.Console.WriteLine(innehåll);
                }
                else
                {
                    System.Console.WriteLine("Filen finns inte");
                }

            }
        }
    }
}
