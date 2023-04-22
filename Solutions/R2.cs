using System;

namespace KattisSubmissions.Solutions
{
    internal class R2
    {
        static void Main(string[] args)
        {
            string? line = Console.ReadLine();
            string[] split = line!.Split(new char[] { ' ' }, StringSplitOptions.None);
            int r1 = int.Parse(split[0]);
            int s = int.Parse(split[1]);
            // s = (r1+r2)/2
            // s * 2 = r1 + r2
            // s * 2 - r1 = r2
            Console.WriteLine(s * 2 - r1);
        }
    }
}
