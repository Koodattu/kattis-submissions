using System;

namespace KattisSubmissions.Solutions
{
    internal class QualityAdjustedLifeYear
    {
        static void Main(string[] args)
        {
            double total = 0;
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] split = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None);
                double a = double.Parse(split[0]);
                double b = double.Parse(split[1]);
                total += a * b;
            }

            Console.WriteLine(total.ToString("#.000"));
        }
    }
}
