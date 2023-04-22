using System;

namespace KattisSubmissions.Solutions
{
    internal class StuckInATimeLoop
    {
        static void Main(string[] args)
        {
            string? line = Console.ReadLine();
            int a = int.Parse(line!);
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i + 1 + " Abracadabra");
            }
        }
    }
}