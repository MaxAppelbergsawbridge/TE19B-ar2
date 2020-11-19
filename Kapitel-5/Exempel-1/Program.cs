using System;

namespace Exempel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //alt1:strings
            //array av tre städer:"Sydney,Paris,London
            string[] städer = { "Sydney", "Paris", "London" };//låst till 3
            //använda array:n
            Console.WriteLine(städer[2]);
            //alt2:tom array med 2 strings
            string[] länder = new string[2];
            Console.WriteLine(länder[1]);
            //alt3:tom array med 3 int
            int[] årtal = new int[3];
            länder[0] = "Frankrike";
            länder[1] = städer[1];
            Console.WriteLine(länder[1]);
            årtal[0] = 2000;
        }
    }
}
