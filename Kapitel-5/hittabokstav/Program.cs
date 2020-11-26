using System;

namespace hittabokstav
{
    class Program
    {
        static void Main(string[] args)
        {
            //ange en bokstav
            Console.WriteLine("Ange en bokstav");
            string bokstav = Console.ReadLine();

            //skapa en samling för alfabetet(string)
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";

            //småbokstäver omvandlas till stora
            bokstav = bokstav.ToUpper();

            //hitta bokstavens plats i alfabetet
            int index = alfabetet.IndexOf(bokstav);
            Console.WriteLine(index);

            //skapa en samling av morsekod
            string[] morsekoden = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };
            string morsekod = morsekoden[index];

            //skriv ut morsekoden
            Console.WriteLine(morsekod);
        }
    }
}