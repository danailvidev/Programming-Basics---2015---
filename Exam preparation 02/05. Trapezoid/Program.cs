using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = n;

            for (int row = 0; row < n + 1; row++)
            {
                for (int col = 0; col < n* 2; col++)
                {
                 
                    if ( col == n*2-1 || row == 0 && col >= n || row == n )
                    {

                        Console.Write("*");
                        
                    }
                    else if(col == count - 1 && row > 0)
                    {
                        Console.Write("*");
                        count--;
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
