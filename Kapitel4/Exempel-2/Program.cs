using System;

namespace Exempel_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";
            //presentera en meny som visas tills användare säger stop
            while (val != "3")
            {
                Console.WriteLine("välj något av följande tal?");
                Console.WriteLine("1.addera 2 tal");
                Console.WriteLine("2.multiplicera 2 tal");
                Console.WriteLine("3. avsluta");
                val = Console.ReadLine();
                switch (val)
                {

                    case "1":
                        Console.WriteLine("välj 1 tal");
                        int addera1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("välj 1 tal");
                        int addera2 = int.Parse(Console.ReadLine());
                        int slutprodukt = addera1 + addera2;
                        Console.WriteLine(slutprodukt);
                        break;
                    case "2":
                        Console.WriteLine("välj 1 tal");
                        int multiplicera1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("välj 1 tal");
                        int multiplicera2 = int.Parse(Console.ReadLine());
                        int slutprodukt2 = multiplicera1 * multiplicera2;
                        Console.WriteLine(slutprodukt2);
                        break;
                    default:
                        break;
                }
            }


        }
    }
}
