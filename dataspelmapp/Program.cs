using System;

namespace dataspelmapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Skapa en matris med strängar
            int[,] karta = {
                {1, 1, 1, 1, 1, 1, 1},
                {1, 0, 0, 0, 0, 0, 1},
                {1, 0, 1, 1, 1, 0, 1},
                {1, 0, 1, 1, 0, 0, 1},
                {1, 0, 1, 1, 0, 1, 1},
                {1, 0, 0, 0, 0, 0, 1},
                {1, 0, 1, 1, 1, 1, 1}
            };
            //var är spelare
            int spelarePositiony = 6;
            int spelarePositionx = 2;
            Random slumpmotor = new Random();
            int antalringar = 3;
            while (antalringar != 0)
            {
                int x = slumpmotor.Next(0, 7);
                int y = slumpmotor.Next(0, 7);
                //om vi hamnar i en gång
                if (karta[y, x] == 0)
                {
                    karta[y, x] = 2;
                    antalringar--;
                }

            }
            while (true)
            {
                Console.Clear();

                karta[spelarePositiony, spelarePositionx] = 3;
                for (int y = 0; y < 7; y++)
                {
                    for (int x = 0; x < 7; x++)
                    {
                        switch (karta[y, x])
                        {
                            case 1: // En vägg
                                Console.Write('\u2B1C');
                                break;
                            case 2://poäng
                                Console.Write("⭕");
                                break;
                            case 3:
                                System.Console.Write("⭐");
                                break;
                            default: // En gång
                                Console.Write('\u2B1B');
                                break;
                        }
                    }
                    Console.WriteLine();
                }
                System.Console.WriteLine("W,A,S,D");
                string direction = Console.ReadLine().ToUpper().Substring(0, 1);

                switch (direction)
                {
                    case "A":
                        spelarePositionx--;
                        break;
                    case "S":
                        spelarePositiony++;
                        break;
                    case "D":
                        spelarePositionx++;
                        break;
                    case "W":
                        spelarePositiony--;
                        break;
                    case "C":
                        break;
                    default:
                        System.Console.WriteLine("försök igen");
                        break;
                }
                karta[spelarePositiony, spelarePositionx] = 3;
            }
        }
    }
}
