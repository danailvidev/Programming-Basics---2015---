using System;

namespace _05.Formatting_Numbers
{
    class FormattingNumbers
    {
        /*Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them 
        in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal,
        left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits
        after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned.*/
        static void Main()
        {        
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            string aBinary = Convert.ToString(a, 2);
            Console.WriteLine($"|{a,0:X}{"|"+aBinary.PadLeft(8,'0'),15}|{b,10:f2}|{c,0:f3}|");
        }
    }
}
