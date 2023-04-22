using System;

namespace KattisSubmissions.Solutions
{
    internal class Quadrant
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int quadrant = 0;

            if (x >= 0 && y >= 0)
            {
                quadrant = 1;
            }

            if (x <= 0 && y >= 0)
            {
                quadrant = 2;
            }

            if (x <= 0 && y <= 0)
            {
                quadrant = 3;
            }

            if (x >= 0 && y <= 0)
            {
                quadrant = 4;
            }

            Console.WriteLine(quadrant);
        }
    }
}
