using System;

namespace Uppgift6._13
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(slumpmånad());
            System.Console.WriteLine(slumpårtal());
        }
        static Random slump = new Random();
        static int slumpårtal()
        {
            int x = slump.Next(1899, 2000);
            return x;
        }
        static int slumpmånad()
        {
            int x = slump.Next(0, 12);
            return x;
        }
    }
}
