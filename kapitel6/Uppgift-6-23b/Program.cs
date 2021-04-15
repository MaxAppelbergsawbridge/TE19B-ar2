using System;

namespace Uppgift_6_23b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange en text");
            string meddelande = Console.ReadLine();
            //    System.Console.WriteLine(GörVarannanStor(meddelande));
            System.Console.WriteLine(GörFörstaBokstavStor(meddelande));
        }
        static string GörVarannanStor(string texten)
        {
            //gör alla bokstäver till småbokstäver
            texten = texten.ToLower();
            //Dela upp texten vid mellanslag
            string[] orden = texten.Split(' ');
            //loopa igenom orden
            for (int i = 0; i < orden.Length; i += 2)
            {
                orden[i] = orden[i].ToUpper();
            }
            return string.Join(" ", orden);
        }
        static string GörFörstaBokstavStor(string texten)
        {
            //gör alla bokstäver till småbokstäver
            texten = texten.ToLower();
            //Dela upp texten vid mellanslag
            string[] orden = texten.Split(' ');
            //string[] tecken;
            //loopa igenom orden
            for (int i = 0; i < orden.Length; i++)
            {
                //tecken[i] = orden[i];
                //tecken[0] = tecken[0].ToUpper();
                orden[i] = orden[i].Substring(0, 1).ToUpper() + orden[i].Substring(1).ToLower();
            }
            return string.Join(" ", orden);
        }
    }
}
