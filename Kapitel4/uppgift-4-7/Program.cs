using System;

namespace uppgift_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //läs in siffra
            Console.Write("ange en siffra");
            string siffra = Console.ReadLine();
            int nynumner = 0;
            //plocka isär siffra
            for (int i = 0; i < siffra.Length; i++)
            {
                string numner = siffra[i].ToString();
                int tal = int.Parse(numner);
                nynumner += tal;
            }
            //plussa ihop siffror
            Console.Write($"summan av talet {siffra} är {nynumner}");
        }
    }
}
