using System;

namespace uppgift_5_16
{
    class Program
    {
        static void Main(string[] args)

        {// alfabet a=a i namn
            string alfabet = "abdefghijklmnopqrstuvwxyzåäö";
            string[] namn = { "Beth", "Liz", "Winston", "a", "b", "c" };
            string example = " ";
            string compare = " ";
            int[] points = new int[5];
            for (int i = 0; i < namn.Length; i++)
            {
                example = namn[i];
                System.Console.WriteLine(example);
                for (int x = 0; x < example.Length; x++)
                {
                    System.Console.WriteLine(x);
                    for (int y = 0; y < alfabet.Length; y++)
                    {
                        compare += example;
                        System.Console.WriteLine(example);
                        for (int j = 0; j < points.Length; j++)
                        {
                            System.Console.WriteLine(points[j]);
                        }
                        points[i] = alfabet.IndexOf(compare);
                    }
                }
                //whatever has the most points[i]=namn[i] 3,5,6,1,2 6,5,3,2,1,i=3/points[3]=1,
            }

        }
    }
}
