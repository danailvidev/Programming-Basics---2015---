using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sand_Watch
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n / 2 +1; row++)
            {
                string dots = new string('.', row);
                string stars = new string('*', n -(row*2));

                Console.WriteLine("{0}{1}{0}",dots,stars);
            }
            for (int row = 1; row <= n / 2; row++)
            {
                string dots = new string('.', n /2 - row);
                string stars = new string('*', 2 * row +1);

                Console.WriteLine("{0}{1}{0}", dots, stars);
            }
        }
    }
}
