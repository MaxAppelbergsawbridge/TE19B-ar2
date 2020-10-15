using System;

namespace Projekt_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //highscore
            int antaletRätt = 0;
            //namn
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            //frågar spelaren olika frågor beroende på vilken varv det är på
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    //frågan
                    string rättsvar = "3";
                    Console.WriteLine("fråga1 Vart är a?");
                    Console.WriteLine("1.c");
                    Console.WriteLine("2.b");
                    Console.WriteLine("3.a");
                    //läser in svaret
                    string svar = Console.ReadLine();
                    if (int.TryParse(svar, out svarout))
                    {
                        Console.WriteLine("Vad bra");
                    }
                    else
                    {
                        Console.WriteLine("Nej jag bad om ett tal, försök igen");
                    }
                    if (svarout == rättsvar)
                    {
                        Console.WriteLine("bra jobbat");
                        antaletRätt++;
                    }
                }
                if (i == 1)
                {
                    //frågan
                    string rättsvar = "1";
                    Console.WriteLine("fråga2:vart är c?");
                    Console.WriteLine("1.c");
                    Console.WriteLine("2.b");
                    Console.WriteLine("3.a");
                    //läser in svaret
                    string svar = Console.ReadLine();
                    if (int.TryParse(svar, out svarout))
                    {
                        Console.WriteLine("Vad bra");
                    }
                    else
                    {
                        Console.WriteLine("Nej jag bad om ett tal, försök igen");
                    }
                    if (svarout == rättsvar)
                    {
                        Console.WriteLine("bra jobbat");
                        antaletRätt++;
                    }

                }
                if (i == 2)
                {
                    //frågan
                    string rättsvar = "2";
                    Console.WriteLine("fråga2: Vart är b?");
                    Console.WriteLine("1.c");
                    Console.WriteLine("2.b");
                    Console.WriteLine("3.a");
                    //Läser in svaret
                    string svar = Console.ReadLine();
                    if (int.TryParse(svar, out svarout))
                    {
                        Console.WriteLine("Vad bra");
                    }
                    else
                    {
                        Console.WriteLine("Nej jag bad om ett tal, försök igen");
                    }
                    if (svarout == rättsvar)
                    {
                        Console.WriteLine("bra jobbat");
                        antaletRätt++;
                    }
                }
                //Frågar om spelaren vill spela om
                if (i == 2)
                {
                    Console.WriteLine("vill du spela om?");
                    string slutsvar = Console.ReadLine();
                    if (int.TryParse(slutsvar, out slutSvarout))
                    {
                        Console.WriteLine("Vad bra");
                    }
                    else
                    {
                        Console.WriteLine("Nej jag bad om ett tal, försök igen");
                    }
                    slutSvarout = slutSvarout.ToLower();
                    if (slutSvarout == "ja")
                    {
                        i = -1;
                        Console.WriteLine(antaletRätt);
                    }
                }
            }
            //När frågesporten är klar
            Console.WriteLine(namn + "hade" + antaletRätt + "frågor rätt!");
            Console.WriteLine("Tack för att du spelade!");
        }
    }
}
