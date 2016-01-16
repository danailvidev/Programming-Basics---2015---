using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Trapezoid_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.',n));
            Console.WriteLine(new string('*', n));

            for (int row = n-1; row >= 0; row--)
            {
                for (int col = 0; col < n*2; col++)
                {
                    if(row==col || row==0 || col == 2 * n - 1)
                        Console.Write('*');
                    else
                        Console.Write('.');
                }
                Console.WriteLine();
            }
        }
    }
}
