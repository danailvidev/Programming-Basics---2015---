using System;

namespace _11.Bitwise_Extract_Bit_3
{
    class Bitwise_Extract_Bit_3
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); 
            int pos = 3;

            int bit = (int)(num >> pos) & 1;

            Console.WriteLine("bit #3: {0}", bit);
        }
    }
}
