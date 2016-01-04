using System;

namespace _04.Number_Comparer
{
    class NumberComparer
    {
        //Write a program that gets two numbers from the console and prints the greater of them.Try to implement this without if statements.
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());      
            Console.WriteLine(Math.Max(a, b)+" is the greater");
        }
    }
}
