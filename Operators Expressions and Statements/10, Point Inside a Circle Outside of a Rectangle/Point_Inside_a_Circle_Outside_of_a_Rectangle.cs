using System;

namespace _10__Point_Inside_a_Circle_Outside_of_a_Rectangle
{
    class Point_Inside_a_Circle_Outside_of_a_Rectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double circlePointX = x - 1;
            double y = double.Parse(Console.ReadLine());
            double circlePointY = y - 1;
            double circleRadius = 1.5;

            // Rectangle Sides Coordinates         
            double topY = 1;
            double rightX = 5;
            double bottomY = -1;
            double leftX = -1;

            double rectanglePointX = x - (-1);
            double rectanglePointY = y - 1;

            if ((circlePointX * circlePointX + circlePointY * circlePointY) <= (circleRadius * circleRadius))
            {
                if (!((rectanglePointY < topY) && (rectanglePointY > bottomY) && (rectanglePointX < rightX) && (rectanglePointX > leftX)))
                {
                    Console.WriteLine("yes");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
