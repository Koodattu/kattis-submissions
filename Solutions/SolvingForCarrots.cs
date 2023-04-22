using System;

namespace KattisSubmissions.Solutions
{
    internal class SolvingForCarrots
    {
        static void Main(string[] args)
        {
            string? line = Console.ReadLine();
            string[] split = line!.Split(new char[] { ' ' }, StringSplitOptions.None);
            Console.WriteLine(split[1]);
        }
    }
}
