using System;

namespace _07.PointinaCircle
{
    class PointinaCircle
    {
        static void Main()
        {
           
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double radius = 2;

            if ((x * x + y * y) <= (radius * radius))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
