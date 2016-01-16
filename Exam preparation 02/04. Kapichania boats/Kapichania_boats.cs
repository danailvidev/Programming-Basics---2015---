using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Kapichania_boats
{
    class Kapichania_boats
    {
        static void Main()
        {
            int bottom = int.Parse(Console.ReadLine());
            int width = bottom * 2 - 1;
            int height = 6 + ((bottom -3) /2 ) *3;
            int sails = 2 * height / 3;
            int basE = height / 3;
            int counter = bottom;

            for (int col = 0; col < bottom; col++)
            {
                for (int row = 0; row < bottom; row++)
                {
                    if(row == counter)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                Console.Write("*");
                for (int row = bottom-1; row >= 0; row--)
                {
                    if (row == counter)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    
                }
                Console.WriteLine();
                counter--;
                
            }
            for (int i = 0; i < bottom*2+1; i++)
            {
                Console.Write('*');
            }
            counter++;
            Console.WriteLine();
            for (int i = 0; i < basE -1; i++)
            {
                for (int row = 0; row < bottom; row++)
                {
                    if (row == counter)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.Write("*");
                for (int row = bottom - 1; row >= 0; row--)
                {
                    if (row == counter)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
                counter++;
            }
            string lastDots = new string('.', (width - bottom) / 2 +1);
            string lastStars = new string('*', bottom);
            Console.Write("{0}{1}{0}",lastDots,lastStars);

        }
    }
}
