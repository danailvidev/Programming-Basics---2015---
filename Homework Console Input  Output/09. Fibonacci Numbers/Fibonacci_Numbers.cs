﻿using System;

namespace _09.Fibonacci_Numbers
{
    class Fibonacci_Numbers
    {
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci 
        //    sequence(at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
        //Note that you may need to learn how to use loops.

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstNum = 0;
            int secondNum = 1;
            int fibNumber ;
            for (int i = 1; i < n; i++)
            {
                fibNumber = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = fibNumber;
                Console.Write(fibNumber+", ");
            }
        }
    }
}
