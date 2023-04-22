using System;

namespace KattisSubmissions.Solutions
{
    internal class JumboJavelin
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int size = 1 - count;
            for (int i = 0; i < count; i++)
            {
                size += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(size);
        }
    }
}
