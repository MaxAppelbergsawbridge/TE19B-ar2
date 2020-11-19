using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            /*skapa en array*/
            string[] svenskaStäder = new string[3];
            svenskaStäder[0] = "Stockholm";
            svenskaStäder[1] = "Göteborg";
            Console.WriteLine("skriv in ett Svenskt stad");
            svenskaStäder[2] = Console.ReadLine();
            Console.WriteLine("du skriv in" + svenskaStäder[2] + "de andra städer är" + svenskaStäder[0] + "och" + svenskaStäder[1]);
            for (int i = 0; i < svenskaStäder.Length; i++)
            {
                Console.WriteLine(svenskaStäder[i]);
            }
        }
    }
}
