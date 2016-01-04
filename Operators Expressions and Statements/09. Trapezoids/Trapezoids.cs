using System;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * height;

            Console.WriteLine("trapezoid's area : {0}", area);
        }
    }
}
