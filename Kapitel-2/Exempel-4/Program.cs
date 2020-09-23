using System;

namespace Exempel_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //datatyper
            Double delat = 7 / 2;
            Console.WriteLine("delat=" + delat);
            Double delat2 = (double)7 / 2;
            Console.WriteLine("delat=" + delat2);
            Double delat3 = 7d / 2;
            Console.WriteLine("delat=" + delat3);
            float delat4 = 7f / 2;
            Console.WriteLine("delat=" + delat4);
            //string
            Console.Write("ange email");
            string email = Console.ReadLine();
            int position = email.IndexOf("@");
            Console.WriteLine("@ ligger position=" + position);
            string anamn = email.Substring(0, position);
            Console.WriteLine("namndelen =" + anamn);
            string domän = email.Substring(position + 1);
            Console.WriteLine("Domändelen" + domän);







        }
    }
}
