using System;

namespace _07.Sort_3_Numbers_with_Nested_Ifs
{
    class Sort_3_Numbers_with_Nested_Ifs
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a >= b && a >=c)
            {
                if (b >= c)
                {
                    Console.WriteLine($"{a} {b} {c}");  //visual studio 2015 .NET 4.5.2
                }
                else
                {
                    Console.WriteLine($"{a} {c} {b}");  //visual studio 2015 .NET 4.5.2
                }
                
            }
            else if (b >= c && b >= a )
            {
                if (c >= a)
                {
                    Console.WriteLine($"{b} {c} {a}");  //visual studio 2015 .NET 4.5.2
                }
                else
                {
                    Console.WriteLine($"{b} {a} {c}");  //visual studio 2015 .NET 4.5.2
                }
            }
            else if (c >= a && c >= b)
            {
                if (b >= a)
                {
                    Console.WriteLine($"{c} {b} {a}");  //visual studio 2015 .NET 4.5.2
                }
                else
                {
                    Console.WriteLine($"{c} {a} {b}");  //visual studio 2015 .NET 4.5.2
                }
            }
            
        }
    }
}
