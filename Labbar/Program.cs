using System;

namespace Labbar
{
    class Program
    {
        static void Main(string[] args)
        {
            double tränatTimmar = 0;
            Console.WriteLine("Hur många timmar ägnar du åt att träna?");
            string användarensSvar = Console.ReadLine();
            while (!double.TryParse(användarensSvar, out tränatTimmar) && tränatTimmar <= 0)
            {
                Console.WriteLine("Tal tack");
                användarensSvar = Console.ReadLine();
            }
            DateTime datumklar = DateTime.Today.AddDays(10000 / tränatTimmar);
            TimeSpan hurLångtid = datumklar - DateTime.Today;
            int.antalÅr = hurLångtid / 365;
            Console.WriteLine($"Du kommer vara färdig i {antalÅr} vid den tiden så kommer det vara år{datumklar}");
        }
    }
}
