using System;

namespace _08.Prime_Number_Check
{
    class Prime_Number_Check
    {
        static void Main()
        {
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(i));
        }

        public static bool isPrime(int value)
        {
            if (value == 1) return false;
            if (value == 2) return true;
            if (value == 3) return true;
            if (value == 5) return true;
            if (value == 7) return true;
            return !((value % 3 == 0) || (value % 2 == 0) || (value % 5 == 0) || (value % 7 == 0));
           
        }
    }
}


