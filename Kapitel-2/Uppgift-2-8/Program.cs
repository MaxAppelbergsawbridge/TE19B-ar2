using System;

namespace Uppgift_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Skapa ett program där användaren på endast en rad ska skriva in en addition av två heltal som ska utföras . 
            Användaren ska inte skriva några mellanslag, t.ex. kan hen skriva 4+3 eller 10+27. 
            Beräkna svaret och skriv ut det.
            */
            Console.WriteLine("addition");
            //läs texten
            string addition = Console.ReadLine();
            //plocka talen
            int platsPlustecken = addition.IndexOf("+");
            int numner1 = int.Parse(addition.Substring(0, platsPlustecken));
            int numner2 = int.Parse(addition.Substring(platsPlustecken + 1));
            //Räkna ut summan
            int summa = numner1 + numner2;
            //skriv ut svaret
            Console.WriteLine("Summan är" + summa);

        }
    }
}
