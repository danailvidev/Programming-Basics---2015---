using System;

namespace _10.Numbers_in_Interval_Dividable_by_Given_Num
{
    class Numbers_in_Interval_Dividable_by_Given_Num
    {
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder
        //    of the division by 5 is 0. 
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int count=0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i+", ");
                    count++;
                }
            }
            Console.WriteLine($"count: {count}");
        }
    }
}
