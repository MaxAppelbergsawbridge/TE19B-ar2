using System;

namespace Uppgift_6_23
{
    class Program
    {
        static void main(string[] args)
        {
            Console.Write("Ange en text");
            string meddelande = Console.ReadLine();
            System.Console.WriteLine(GörVarannanStor(meddelande));
        }
        static string GörVarannanStor(string texten)
        {
            //gör alla bokstäver till småbokstäver
            texten.ToLower();
            //Dela upp texten vid mellanslag
            string[] orden = texten.Split(' ');
            //loopa igenom orden
            for (int i = 0; i < orden.Length; i + 2)
            {
                orden[i].ToUpper();
            }
            return string.Join(" ", orden);
        }
    }
}
