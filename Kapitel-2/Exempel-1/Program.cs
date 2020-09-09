using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarera en variabel för namnet 
            string namn = "";
            string hobby = "";
            string meddelande = "";
            //Fråga om namn
            Console.Write("Vad heter du? ");
            // läs in namnet
            namn = Console.ReadLine();
            //fråga om hobby
            Console.WriteLine("Vad har du för hobby?");
            //Läs in  hobby
            hobby = Console.ReadLine();
            //sätter in meddelande 
            meddelande = ("Hej! " + namn + ",du gillar " + hobby + ".");
            //skriver ut meddelandet
            Console.WriteLine(meddelande);
        }
    }
}
