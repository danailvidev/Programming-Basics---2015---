using System;

namespace _03.Divide_by_7_and_5
{
    class Divide_by_7_and_5
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine((n % 5 == 0)&&(n % 7 == 0));
        }
    }
}
