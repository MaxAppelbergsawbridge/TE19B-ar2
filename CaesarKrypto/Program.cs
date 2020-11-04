using System;

namespace CaesarKrypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange en text");
            string text = Console.ReadLine();
            Console.Write("Hur mycket vill du hoppa?");
            string nyckelstring = Console.ReadLine();
            int y = 0;
            while (!int.TryParse(nyckelstring, out y))
            {
                Console.Write("Hur mycket vill du hoppa?");
                nyckelstring = Console.ReadLine();
            }
            //hitta antaltecken
            int antaltecken = text.Length;
            Console.WriteLine($"Texten är {antaltecken} tecken lång");
            string meddelande = "";
            //loopa igenom inmatat text
            for (int i = 0; i < antaltecken; i++)
            {
                Console.WriteLine($"Loop nr{i}");
                //plockaut bokstav
                char bokstav = text[i];
                Console.WriteLine($"Bokstäven{i} är {bokstav}");
                //ascii värdet för bokstäven
                int ascii = (int)bokstav;
                Console.WriteLine($"Bokstäven {bokstav} har ascii värdet{ascii}");
                ascii = ascii + y;
                char krypterad = (char)ascii;
                Console.WriteLine($"bokstäven {bokstav}krypteras till{krypterad}");
                meddelande += krypterad.ToString();
            }
            Console.WriteLine($"Det kryterade meddelandet är: {meddelande}");
        }
    }
}
