using System;

namespace _14.Comparing_Floats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("enter first number");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            double b = double.Parse(Console.ReadLine());

            double diff = a - b;
            diff = Math.Abs(diff);
            if (diff < 0.000001)
            {
                Console.WriteLine("numbers are equeal");
            }
            else
            {
                Console.WriteLine("numbers are not equeal");
            }
        }
    }
}
