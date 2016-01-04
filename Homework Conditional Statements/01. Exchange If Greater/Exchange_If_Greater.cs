using System;

namespace _01.Exchange_If_Greater
{
    class Exchange_If_Greater
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            
            if (a > b)
            {
                Console.WriteLine("{1} {0}", a ,b);
            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            } 
        }
    }
}
