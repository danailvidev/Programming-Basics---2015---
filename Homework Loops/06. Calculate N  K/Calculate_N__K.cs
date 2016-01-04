using System;

namespace _06.Calculate_N__K
{
    class Calculate_N__K
    {
        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 
        static void Main()
        {
            float n = float.Parse(Console.ReadLine());
            float k = float.Parse(Console.ReadLine());
            float factorielK = 1;
            float factorielN = 1;
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
                if (k >= i)
                {
                    factorielK *= i;
                }
            }
            Console.WriteLine(factorielN/factorielK); 
        }
    }
}
