using System;

namespace Uppgift_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa ett program där användaren får skriva in en mening (utan punkt) som består av två ord. 
            //Skriv ut orden till användaren i omvänd ordning.
            Console.WriteLine("Skriv en mening med två ord utan punkt.");
            string mening = Console.ReadLine();
            int position = mening.IndexOf(" ");
            string ord1 = mening.Substring(0, position);
            string ord2 = mening.Substring(position + 1);
            Console.WriteLine(ord2 + " " + ord1);

        }
    }
}
