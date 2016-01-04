using System;

namespace _05.Calculate_1_1X__2X2__NXN
{
    class Calculate_1_1X__2X2__NXN
    {
        //Write a program that, for a given two integer numbers n and x, calculates the sum 
        //S = 1 + 1!/x + 2!/x2 + … + n!/xn.Use only one loop.Print the result with 5 digits after the decimal point.
        static void Main()
        {
            float n = float.Parse(Console.ReadLine());
            float x = float.Parse(Console.ReadLine());
            float sum = 1;
            float factorial = 1;
            float pow = x;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial / x;
                x *= pow;
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
