using System;

namespace _13.Null_Values_Arithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            //Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console.
            //Try to add some number or the null literal to these variables and print the result.

            int? a = null;
            double? b = null;
            Console.WriteLine("{0};{1}", a, b);

            a += null;
            b += null;
            Console.WriteLine("{0};{1}", a, b);

            a += +5;
            b += +5.5;
            Console.WriteLine("{0};{1}", a, b);
        }
    }
}
