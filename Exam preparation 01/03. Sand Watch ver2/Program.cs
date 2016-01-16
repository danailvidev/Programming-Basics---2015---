using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sand_Watch_ver2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col <= row && row >= n- 1 -col)
                    {
                        Console.Write("*");

                    }
                    else if (col >= row && row <= n - 1 - col)
                    {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
