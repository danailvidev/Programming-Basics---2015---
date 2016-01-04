using System;

namespace _03.Min_Max_Sum_and_Average_of_N_Numbers
{
    class Min_Max_Sum_and_Average_of_N_Numbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double max = 0;
            double min = 0;
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                sum += x;
                if (x > max)
                {
                    max = x;
                }
                else
                {
                    min = x;
                }
            }
            Console.WriteLine("avg: {0:F2}",sum/n);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("max: " + max);
            Console.WriteLine("min: " + min);
        }
    }
}
