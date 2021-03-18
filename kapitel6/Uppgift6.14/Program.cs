using System;

namespace Uppgift6._14
{
    class Program
    {
        static Random slump = new Random();
        static void Main(string[] args)
        {
            System.Console.WriteLine(SlumpaPosition());
        }
        /// <summary>
        /// Slumpar fram ett rad på ett shackbräd  
        /// </summary>
        /// <returns>int rad</returns>
        static int SlumpaRad()
        {
            int rad = slump.Next(0, 8);
            return rad;
        }
        /// <summary>
        /// slumpar fram ett kolumn på ett schackbräd
        /// </summary>
        /// <returns>string kolumn</returns>
        static char SlumpaKolumn()
        {
            string kolumn = "abcdefgh";
            return kolumn[slump.Next(0, 8)];
        }
        /// <summary>
        /// skriver ut en postion
        /// </summary>
        static string SlumpaPosition()
        {
            string postion = SlumpaKolumn().ToString() + SlumpaRad();
            return postion;
        }
    }
}
