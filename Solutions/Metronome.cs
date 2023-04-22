using System;

namespace KattisSubmissions.Solutions
{
    internal class Metronome
    {
        static void Main(string[] args)
        {
            int ticks = int.Parse(Console.ReadLine());

            double revolutions = (double)ticks / 4;

            Console.WriteLine(revolutions.ToString("#.00"));
        }
    }
}
