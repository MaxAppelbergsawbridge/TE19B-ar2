using System;

namespace uppgift_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string numner = "";
            bool tal7 = false;
            bool tal3 = false;

            for (int i = 0; i < numner.Length; i++)
            {
                Console.WriteLine("Skriv in ett tal");
                numner = Console.ReadLine();
                if (numner[i] = "3")
                {
                    tal3 = true;
                }
                else if (numner[i] = "7")
                {
                    tal7 = true;
                }
            }
            if (tal7)
            {
                Console.Write("Ditt meddelande innehåller talet 7");
            }
            else if (tal3)
            {
                Console.Write("Ditt meddelande innehåller talet 3");
            }
            else if (tal3 && tal7)
            {
                Console.Write("Ditt meddelande innehåller talet 3 och 7");
            }
            else
            {
                Console.Write("Ditt meddelande innehåller inte talet 7 eller 3");
            }
        }
    }
}
