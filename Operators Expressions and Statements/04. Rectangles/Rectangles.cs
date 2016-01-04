using System;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("area: " + (a * b) + "\n" + "perimeter: " + 2*(a+ b));
        }
    }
}
