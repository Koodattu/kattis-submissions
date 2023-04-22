using System;

namespace KattisSubmissions.Solutions
{
    internal class KnightPacking
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(size % 2 != 0 ? "first" : "second");
        }
    }
}
