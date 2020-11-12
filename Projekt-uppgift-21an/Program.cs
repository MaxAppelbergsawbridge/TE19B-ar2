using System;

namespace Projekt_uppgift_21an
{
    class Program
    {
        static void Main(string[] args)
        {
            string senasteVinnaren = "ingen vinnare just nu";
            string svårighetsNivå = "";
            // Skriv välkomstmeddelande
            Console.WriteLine("Välkommen till 21:an");
            // Sätt menyVal till "0"
            string menyval = "0";
            // while (menyval != ”4”) 
            while (menyval != "4")
            {
                // Skriv ut meny
                Console.WriteLine("1.Spela 21:an\n2.vem vann sist\n3.Spelets regler\n4.Avsluta programmet");
                // Läs in menyVal
                menyval = Console.ReadLine();
                // switch menyVal
                switch (menyval)
                {
                    // case 1: Spela en omgång av 21:an
                    // case 2: Visa senaste vinnaren
                    // case 3: Visa spelets regler
                    // case 4: Gör ingenting (programmet avslutas)
                    // default: Skriv att alternativet var ogiltigt
                    case "1":
                        Console.WriteLine("välj en svårighetsnivå");
                        svårighetsNivå = Console.ReadLine();
                        int förstaSpelarenspoäng = 0;
                        int andraSpelarenspoäng = 0;
                        Console.WriteLine("Nu dras 2 kort för både spelare");
                        Random slumpkort = new Random();
                        förstaSpelarenspoäng += slumpkort.Next(1, 11);
                        förstaSpelarenspoäng += slumpkort.Next(1, 11);
                        andraSpelarenspoäng += slumpkort.Next(1, 11);
                        andraSpelarenspoäng += slumpkort.Next(1, 11);
                        string kortVal = "";
                        while (kortVal != "n" && förstaSpelarenspoäng <= 21)
                        {
                            Console.WriteLine($"Din poäng: {förstaSpelarenspoäng}");
                            Console.WriteLine($"Datorns poäng: {andraSpelarenspoäng}");
                            Console.WriteLine("Vill du ha ett till kort? (j/n)");
                            kortVal = Console.ReadLine();
                            switch (kortVal)
                            {
                                case "j":
                                    int nyPoäng = slumpkort.Next(1, 11);
                                    förstaSpelarenspoäng += nyPoäng;
                                    Console.WriteLine($"Ditt nya kort är värt {nyPoäng} poäng");
                                    Console.WriteLine($"Din totalpoäng är {förstaSpelarenspoäng}");
                                    break;

                                case "n":
                                    break;

                                default:
                                    Console.WriteLine("Du valde inte ett giltigt alternativ");
                                    break;
                            }
                        }
                        // Gå tillbaka till huvudmenyn om användaren har över 21
                        if (förstaSpelarenspoäng > 21)
                        {
                            Console.WriteLine("Du har mer än 21 och har förlorat");
                            break;
                        }

                        // Datorn drar kort tills den vinner eller går över 21
                        if (svårighetsNivå == "1")
                        {
                            while (andraSpelarenspoäng < förstaSpelarenspoäng && andraSpelarenspoäng <= 21)
                            {
                                int datornsNyaPoäng = slumpkort.Next(1, 11);
                                andraSpelarenspoäng += datornsNyaPoäng;
                                Console.WriteLine($"Datorn drog ett kort värt {datornsNyaPoäng}");
                            }

                        }
                        else
                        {
                            while (förstaSpelarenspoäng < 9 && andraSpelarenspoäng <= 15)
                            {
                                int datornsNyaPoäng = slumpkort.Next(1, 11);
                                andraSpelarenspoäng += datornsNyaPoäng;
                                Console.WriteLine($"Datorn drog ett kort värt {datornsNyaPoäng}");
                            }
                        }
                        Console.WriteLine($"Din poäng: {förstaSpelarenspoäng}");
                        Console.WriteLine($"Datorns poäng: {andraSpelarenspoäng}");
                        // Undersök vem som vann
                        if (andraSpelarenspoäng > 21)
                        {
                            Console.WriteLine("Du har vunnit!");
                            Console.WriteLine("Skriv in ditt namn");
                            senasteVinnaren = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Datorn har vunnit!");
                            senasteVinnaren = "datorn";
                        }
                        Console.WriteLine("Vill du spela igen? ");
                        string svar = Console.ReadLine();
                        if (svar == "ja")
                        {
                            menyval = "1";
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "2":
                        Console.WriteLine($"Senaste vinnaren är {senasteVinnaren}");
                        break;
                    case "3":
                        Console.WriteLine("Ditt mål är att tvinga datorn att få mer än 21 poäng.");
                        Console.WriteLine("Du får poäng genom att dra kort, varje kort har 1-10 poäng.");
                        Console.WriteLine("Om du får mer än 21 poäng har du förlorat.");
                        Console.WriteLine("Både du och datorn får två kort i början. Därefter får du");
                        Console.WriteLine("dra fler kort tills du är nöjd eller får över 21.");
                        Console.WriteLine("När du är färdig drar datorn kort till den har");
                        Console.WriteLine("mer poäng än dig eller över 21 poäng.");
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Du skrev in ogiltig alternativ");
                        break;
                }
            }
        }
    }
}
