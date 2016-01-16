using System;

namespace _01.Cartesian_coordinate_system
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double coor = 0;

            if (x == 0 && y == 0)
            {
                coor = 0;
            }
            else if (x>0 && y > 0)
            {
                coor = 1;
            }
            else if(x<0 && y > 0)
            {
                coor = 2;
            }
            else if (x<0 && y < 0)
            {
                coor = 3;
            }
            else if (x>0 && y < 0)
            {
                coor = 4;
            }
            else if (x == 0 && y != 0)
            {
                coor = 5;
            }
            else if (x !=0 && y == 0){
                coor = 6;
            }
            Console.WriteLine(coor);
        }
    }
}
