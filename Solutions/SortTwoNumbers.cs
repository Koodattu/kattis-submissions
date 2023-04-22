using System;
using System.Linq;

namespace KattisSubmissions.Solutions
{
    internal class SortTwoNumbers
    {
        static void Main(string[] args)
        {
            string? line = Console.ReadLine();
            string[] split = line!.Split(new char[] { ' ' }, StringSplitOptions.None);
            int[] ints = Array.ConvertAll(split, int.Parse);
            Array.Sort(ints);
            Console.WriteLine(string.Join(" ", ints.Select(x => x.ToString()).ToArray()));
        }
    }
}