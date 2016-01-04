using System;

namespace _07.Calculate_N__K__N_K
{
    class Calculate_N__K__N_K
    {
        static void Main()
        {
            //calculates n! / (k! * (n-k)!) 
            double n = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            double factorielK = 1L;
            double factorielN = 1L;
            double factorielNminusK = 1L;
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
                if (k >= i)
                {
                    factorielK *= i;
                }
            }
            for (int i = 1; i <= n - k; i++)
            {
                factorielNminusK *= i;
            }
            Console.WriteLine(factorielN / (factorielK * factorielNminusK));
        }
    }
}
