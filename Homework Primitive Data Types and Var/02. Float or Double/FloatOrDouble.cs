﻿using System;

namespace _02.Float_or_Double
{
    class FloatOrDouble
    {
        static void Main()
        {
            //Which of the following values can be assigned to a variable of type float and which to a variable of type 
            //double: 34.567839023, 12.345, 8923.1234857, 3456.091 ? Write a program to assign the numbers in variables and print them
            //to ensure no precision is lost.
            double a = 34.567839023;
            float b = 12.345f;
            double c = 8923.1234857;
            float d = 3456.091f;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}", a, b, c,d);
        }
    }
}