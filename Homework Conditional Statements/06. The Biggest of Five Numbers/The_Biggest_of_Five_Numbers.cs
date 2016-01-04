using System;

namespace _06.The_Biggest_of_Five_Numbers
{
    class The_Biggest_of_Five_Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine(a + " is the biggest");
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine(b + " is the biggest");
            }
            else if (c >= a && c >= b && c >= d && c >= e)
            {
                Console.WriteLine(c + " is the biggest");
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine(d + " is the biggest");
            }
            else 
            {
                Console.WriteLine(e + " is the biggest");
            }
        }
    }
}
