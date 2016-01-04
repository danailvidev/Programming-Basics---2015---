using System;

namespace _08.Numbers_from_1_to_n
{
    class Numbers_from_1_to_n
    {
        //Write a program that reads an integer number n from the console and prints all the numbers in the interval[1..n], 
         //   each on a single line.Note that you may need to use a for-loop.
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
