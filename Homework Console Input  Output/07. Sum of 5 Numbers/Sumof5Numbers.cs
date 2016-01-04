using System;

namespace _07.Sum_of_5_Numbers
{
    class Sumof5Numbers
    {
        //Write a program that enters 5 numbers(given in a single line, separated by a space), calculates and prints their sum.
        static void Main()
        {
            string numbersSpace = Console.ReadLine();
            string[] nums = numbersSpace.Split(' ');
            double sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += Convert.ToDouble(nums[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
