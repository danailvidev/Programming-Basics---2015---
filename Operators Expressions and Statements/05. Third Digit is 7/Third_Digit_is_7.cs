using System;

namespace _05.Third_Digit_is_7
{
    class Third_Digit_is_7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());          
            Console.WriteLine((n / 100) % 10 == 7);
        }
    }
}
