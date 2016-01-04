using System;

namespace _05.The_Biggest_of_3_Numbers
{
    class The_Biggest_of_3_Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a+" is the biggest");
            }
            else if (a < b && c < b)
            {
                Console.WriteLine(b + " is the biggest");
            }
            else
            {
                Console.WriteLine(c + " is the biggest");
            }
        }
    }
}
