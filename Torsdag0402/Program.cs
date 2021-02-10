﻿using System;
using System.IO;

namespace Torsdag0402
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bordsInformation;
            string filnamn = "centralbord.csv";
            string tomtBordBeskrivning = "0;Inga gäster;0";
            int antalbord = 8;
            int[] nynota = new int[1];

            Console.WriteLine("Detta är Centralrestaurangens bordshanterare");

            // Läs in från fil ifall den finns
            if (File.Exists(filnamn))
            {
                bordsInformation = File.ReadAllLines(filnamn);
                Console.WriteLine("Bordsinformation lästes in från fil");
            }
            else
            {
                // Skapa bordslistan och fyll den med information
                bordsInformation = new string[antalbord];
                for (int i = 0; i < bordsInformation.Length; i++)
                {
                    bordsInformation[i] = tomtBordBeskrivning;
                }
                File.WriteAllLines(filnamn, bordsInformation);
                Console.WriteLine("Fil med bordsinformation hittades ej, ny information skapades");
            }
            Console.WriteLine();

            // Programmets huvudloop
            string menyVal = "0";
            while (menyVal != "5")
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Visa alla bord");
                Console.WriteLine("2. Lägg till/ändra bordsinformation");
                Console.WriteLine("3. Markera att ett bord är tomt");
                Console.WriteLine("4.Lägg till nota");
                Console.WriteLine("5. Avsluta programmet");
                menyVal = Console.ReadLine();

                // Tom rad innan användarens val körs
                Console.WriteLine();

                switch (menyVal)
                {
                    // Visa alla bord
                    case "1":
                        int totaltAntalGäster = 0;
                        for (int i = 0; i < bordsInformation.Length; i++)
                        {
                            if (bordsInformation[i] == tomtBordBeskrivning)
                            {
                                Console.WriteLine($"Bord {i + 1} - Inga gäster");
                                continue;
                            }

                            // Detta sker bara om bordet inte är tomt
                            string[] enskiltBordsinformation = bordsInformation[i].Split(';');
                            int antalGäster = int.Parse(enskiltBordsinformation[0]);
                            string bordsnamn = enskiltBordsinformation[1];
                            totaltAntalGäster += antalGäster;
                            Console.WriteLine($"Bord {i + 1} - Namn: {bordsnamn}, antal gäster: {antalGäster} nota:{nynota[i]}");

                        }
                        Console.WriteLine($"Totalt antal gäster: {totaltAntalGäster}");
                        break;

                    // Lägg till/ändra bordsinformation
                    case "2":
                        Console.WriteLine("Vilket bordsnummer vill du lägga till/ändra informationen för?");
                        int bordsnummerÄndra = int.Parse(Console.ReadLine());
                        if (bordsnummerÄndra <= 0 || bordsnummerÄndra > bordsInformation.Length)
                        {
                            Console.WriteLine($"{bordsnummerÄndra} är inte ett giltigt bordsnummer");
                            break;
                        }

                        string[] nyttBordInfo = new string[2];
                        Console.WriteLine("Skriv in bordets namn");
                        nyttBordInfo[1] = Console.ReadLine();
                        Console.WriteLine("Hur många gäster finns vid bordet?");
                        nyttBordInfo[0] = Console.ReadLine();
                        bordsInformation[bordsnummerÄndra - 1] = string.Join(";", nyttBordInfo);

                        // Uppdatera sparfilen
                        File.WriteAllLines(filnamn, bordsInformation);
                        break;

                    // Markera att ett bord är tomt
                    case "3":
                        Console.WriteLine("Vilket bordsnummer vill du markera som tomt?");
                        int bordsnummerRadera = int.Parse(Console.ReadLine());
                        if (bordsnummerRadera <= 0 || bordsnummerRadera > bordsInformation.Length)
                        {
                            Console.WriteLine($"{bordsnummerRadera} är inte ett giltigt bordsnummer");
                            break;
                        }

                        bordsInformation[bordsnummerRadera - 1] = tomtBordBeskrivning;
                        Console.WriteLine($"Bord {bordsnummerRadera} är markerat som tomt");

                        // Uppdatera sparfilen
                        File.WriteAllLines(filnamn, bordsInformation);
                        break;

                    //lägg till nota
                    case "4":
                        Console.WriteLine("Vilket bordsnummer vill du lägga nota på?");
                        int bordsnummernota = int.Parse(Console.ReadLine());
                        if (bordsnummernota <= 0 || bordsnummernota > bordsInformation.Length)
                        {
                            Console.WriteLine($"{bordsnummernota} är inte ett giltigt bordsnummer");
                            break;
                        }
                        System.Console.WriteLine("Skriv in hur mycket pengar du vill lägga på bordet");
                        string svar = Console.ReadLine();
                        if (!int.TryParse(svar, out nynota[0]))
                        {
                            System.Console.WriteLine("skriv ett tal");
                            break;
                        }
                        bordsInformation[bordsnummernota - 1] = string.Join(";", nynota);
                        // Uppdatera sparfilen
                        File.WriteAllLines(filnamn, bordsInformation);
                        break;
                    // Gör ingenting (programmet avslutas)
                    case "5":
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                }

                // Tom rad innan nästa körning
                Console.WriteLine();
            }
        }
    }
}
