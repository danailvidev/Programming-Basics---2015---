using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Matrix_of_Numbers
{
    class Matrix_of_Numbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0 ; j <= n - 1 ; j++)
                {
                    Console.Write(i + j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
