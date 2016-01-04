using System;

namespace _03.Circle_Perimeter_and_Area
{
    class ProgCirclePerimeterandArearam
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
        static void Main()
        {
            double circleRadius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * circleRadius;
            double circleArea = Math.PI * circleRadius * circleRadius;
            Console.WriteLine($"периметърът е {perimeter:F2}\nрадиусът е {circleArea:F2}");

        }
    }
}
