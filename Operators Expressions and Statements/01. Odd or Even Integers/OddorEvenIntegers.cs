using System;

namespace _01.Odd_or_Even_Integers
{
    class OddorEvenIntegers
    {
        //Write an expression that checks if given integer is odd or even.
        static void Main()
        {

            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(IsEven(i));
        }
            
        public static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
    }
}
