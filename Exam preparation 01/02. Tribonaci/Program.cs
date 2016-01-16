using System;
using System.Numerics;

namespace _02.Tribonaci
{
    class Program
    {
        static void Main()
        {
            BigInteger t1 = BigInteger.Parse(Console.ReadLine());
            BigInteger t2 = BigInteger.Parse(Console.ReadLine());
            BigInteger t3 = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 0;
            for (int i = 3; i < n; i++)
            {
                BigInteger tnew = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = tnew;

                result = t3;
            }

            Console.WriteLine(result);
        }
    }
}
