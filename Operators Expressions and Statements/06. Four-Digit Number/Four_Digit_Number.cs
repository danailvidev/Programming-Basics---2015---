using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Four_Digit_Number
{
    class Four_Digit_Number
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            
            int a = number / 1000;
            int b = (number - a * 1000) / 100;
            int c = (number - (a * 1000 + b * 100)) / 10;
            int d = (number - (a * 1000 + b * 100 + c * 10));
            
            int sum = a + b + c + d;
           
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("the number in reversed order: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Puts the last digit in the first position: {0}{1}{2}{3}", d, b, c, a);
            Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", a, c, b, d);
        }
    }
}
