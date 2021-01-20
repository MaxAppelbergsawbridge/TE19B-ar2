using System;

namespace RussianRoulettemedbetyg
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumptal = new Random();
            //  kasta tärning
            int tärning = slumptal.Next(0, 6);
            Console.WriteLine($"Slumptalet={slumptal}");
            if (tärning == 0)
                System.Console.WriteLine("Du fick betyget F!");
            if (tärning == 1)
                System.Console.WriteLine("Du fick betyget E!");
            if (tärning == 2)
                System.Console.WriteLine("Du fick betyget D!");
            if (tärning == 3)
                System.Console.WriteLine("Du fick betyget C!");
            if (tärning == 4)
                System.Console.WriteLine("Du fick betyget B!");
            if (tärning == 5)
                System.Console.WriteLine("Du fick betyget A!");
            switch (tärning)
            {
                case 1:
                    System.Console.WriteLine("Du fick betyget E!");
                    break;
                case 2:
                    System.Console.WriteLine("Du fick betyget D!");
                    break;
                case 3:
                    System.Console.WriteLine("Du fick betyget C!");
                    break;
                case 4:
                    System.Console.WriteLine("Du fick betyget B!");
                    break;
                case 5:
                    System.Console.WriteLine("Du fick betyget A!");
                    break;
                default:
                    System.Console.WriteLine("Du fick betyget F!");
                    break;
            }
            string[] betyg = { "F", "E", "D", "C", "B", "A" };
            System.Console.WriteLine($"Du fick {betyg[tärning]}");
        }
    }
}
