using System;

namespace morsetolkare
{
    class Program
    {
        static void Main(string[] args)
        {
            //berätta om programmets syfte
            //be om ett meddelande
            string[] morsekoden = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", ".--", "...-", ".--", "-..-", "-.--", "--..", ".--.-", ".-.-", "---.", " " };
            string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ ";
            string morsemeddelande = "";
            Console.WriteLine("Den här programmet översätter din text på morse");
            Console.WriteLine("Skriv gärna ett meddelande");
            string meddelande = Console.ReadLine().ToUpper();
            //loopa igenom meddelandet
            for (int i = 0; i < meddelande.Length; i++)
            {
                int index = alfabetet.IndexOf(meddelande[i]);
                string morsebokstav = morsekoden[index];
                morsemeddelande += morsebokstav;
            }
            //skriv ut varje tecken
            Console.WriteLine(morsemeddelande);
        }
    }
}
