using System;

namespace _11.Random_Numbers_in_Given_Range
{
    class Random_Numbers_in_Given_Range
    {
        //Write a program that enters 3 integers n, min and max(min ≤ max) and prints n random numbers in the range[min...max]. 
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int randomNum = r.Next(min, max + 1);
                Console.Write(randomNum + " ");
            }
        }
    }
}
