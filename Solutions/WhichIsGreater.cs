using System;

namespace KattisSubmissions.Solutions
{
    public class WhichIsGreater
    {
        public static void Main()
        {
            string? line = Console.ReadLine();
            string[] split = line!.Split(new char[] { ' ' }, StringSplitOptions.None);
            int a = int.Parse(split[0]);
            int b = int.Parse(split[1]);
            Console.WriteLine(a > b ? 1 : 0);
        }
    }
}