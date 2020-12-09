using System;

namespace Boye
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAntalord = 0;
            //lagra dikten i en array
            string[] dikt = {
                "Den mätta dagen, den är aldrig störst.",
                "Den bästa dagen är en dag av törst.",
                "Nog finns det mål och mening i vår färd.",
                "men det är vägen, som är mödan värd.",
                "Det bästa målet är en nattlång rast.",
                "där elden tänds och brödet bryts i hast",
                "På ställen dör man sover blott en gång",
                "blir sömnen trygg och drömmen full av gång.",
                "Bryt upp, bryt upp! Den nya dagen gryr",
                "Oändligt är vårt stora äventyr."
            };
            //skriv ut dikten
            //loopa igenom arrayen
            for (int i = 0; i < dikt.Length; i++)
            {
                if (i % 2 == 0)
                {//skriv ut en rad
                    Console.WriteLine(dikt[i]);
                }
                else
                {//skri ut en rad och en tom rad
                    Console.WriteLine(dikt[i] + "\n");
                }
                //räkna orden
                string[] orden = dikt[i].Split(' ');
                int antalord = orden.Length;
                totalAntalord += antalord;
            }
            System.Console.WriteLine($"antal orden i dikten är{totalAntalord}");
        }
    }
}
