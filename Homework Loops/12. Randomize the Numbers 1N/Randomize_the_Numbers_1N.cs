using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Randomize_the_Numbers_1N
{
    class Randomize_the_Numbers_1N
    {
        //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            bool[] printed = new bool[num + 1];
            Random r = new Random();
            int numberToPrint;
            for (int i = 0; i < num; i++)
            {
                numberToPrint = r.Next(0, num + 1);
               if(printed[numberToPrint] == false)
                {
                    Console.WriteLine(numberToPrint + " ");
                    printed[numberToPrint] = true;
                }
                else
                {
                    i--;
                }
            }
        }
    }
}
