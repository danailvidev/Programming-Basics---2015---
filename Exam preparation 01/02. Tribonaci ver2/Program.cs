using System;
using System.Numerics;

namespace _02.Tribonaci_ver2
{
    class Program
    {
        static void Main()
        {
            BigInteger t1 = BigInteger.Parse(Console.ReadLine());
            BigInteger t2 = BigInteger.Parse(Console.ReadLine());
            BigInteger t3 = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            BigInteger[] trib = new BigInteger[Math.Max(n, 3)];
            trib[0] = t1;
            trib[1] = t2;
            trib[2] = t3;

            for (int i = 3; i < trib.Length; i++)
            {
                trib[i] = trib[i-1] + trib[i-2] + trib[i-3];
            }

            Console.WriteLine(trib[n - 1 ]);
        }
    }
}
