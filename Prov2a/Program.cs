using System;
using System.IO;

namespace Prov2a
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista alla filmer 
            //Man ska kunna välja mellan visa alla filmer,sök efter år och avsluta programmet(while)
            System.Console.WriteLine("1.Visa alla filmer \n2.Sök år \n3.Avsluta");
            string svar = Console.ReadLine();
            int val = 0;
            bool flagga = true;
            string[] oneTwothree = { "1", "2", "3" };
            //trodde syntaxen för flera siffror var , och datorn gillar inte|| 
            while (flagga)
            {
                if (!int.TryParse(svar, out val))
                {
                    System.Console.WriteLine("Ange en giltig val");
                }
                else
                {
                    string[] filmer;
                    switch (val)
                    {
                        //visa alla filmer
                        case 1:
                            filmer = File.ReadAllLines("movies.tsv");
                            for (int i = 0; i < filmer.Length; i++)
                            {
                                System.Console.WriteLine(filmer[i]);
                            }
                            System.Console.WriteLine("1.Visa alla filmer \n2.Sök år \n 3.Avsluta");
                            svar = Console.ReadLine();
                            break;
                        /*   case 2:
                               //sök efter filmen
                               System.Console.WriteLine("Vilket år söker du?");
                               string år = Console.ReadLine();
                               //tryparse och interval
                               //dela upp tsv filmen med split och ta ut år delen
                               for (int i = 0; i < filmer.Length; i++)
                               {
                                   string[] rad = filmer.Split('\t');
                                   if (rad[2] == år)
                                   {
                                       System.Console.WriteLine(rad[2]);
                                   }
                                   else
                                   {
                                       System.Console.WriteLine("Gick inte att hitta filmen");
                                   }
                               }
                               System.Console.WriteLine("1.Visa alla filmer \n2.Sök år \n 3.Avsluta");
                               svar = Console.ReadLine();
                               break;*/
                        //avsluta programmet
                        case 3:
                            flagga = false;
                            System.Console.WriteLine("Programmet avslutas");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
