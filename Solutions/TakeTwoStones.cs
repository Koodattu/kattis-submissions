using System;

namespace KattisSubmissions.Solutions
{
    internal class TakeTwoStones
    {
        static void Main(string[] args)
        {
            string? line = Console.ReadLine();
            int a = int.Parse(line!);
            Console.WriteLine(a % 2 != 0 ? "Alice" : "Bob");
        }
    }
}