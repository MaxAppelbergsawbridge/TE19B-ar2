using System;

namespace uppgift_5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapa ett prgoram där användaren får skriva in en rad med tal separerade med plustecken.
            //Programmet ska beräkna summan av alla talen.
            int summa = 0;
            System.Console.WriteLine("Vilka tal vill du summera?");
            string fejktal = Console.ReadLine();
            string[] beräkning = fejktal.Split('+');
            foreach (string ord in beräkning)
            {
                int tal = int.Parse(ord);
                summa += tal;
            }
            System.Console.WriteLine(summa);
        }
    }
}
