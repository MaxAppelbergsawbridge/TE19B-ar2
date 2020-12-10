using System;

namespace Exempel_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //tilemap
            int[,] tilemap = new int[10, 10]{
             {1,0,1,1,1,1,1,1,1,1 },
             {1,0,1,1,1,1,1,1,1,1 },
             {1,0,1,0,0,1,1,1,1,1 },
             {1,0,0,0,0,0,0,3,1,1 },
             {1,0,1,0,0,1,1,0,1,1 },
             {1,0,1,0,0,1,1,0,1,1 },
             {1,0,1,0,0,1,1,0,1,1 },
             {1,0,1,0,0,1,1,0,1,1 },
             {1,0,1,1,1,1,1,0,1,1 },
             {1,0,0,0,0,0,0,0,0,2 },
            };
            Console.OutputEncoding = System.Text.Encoding.Default;
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (tilemap[y, x] == 1)
                    {
                        Console.Write('\u2B1C');
                    }
                    else if (tilemap[y, x] == 2)
                    {
                        Console.Write('\u2690');
                    }
                    else if (tilemap[y, x] == 0)
                    {
                        Console.Write('\u2B1B');
                    }
                    else if (tilemap[y, x] == 3)
                    {
                        Console.Write('\u2708');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
