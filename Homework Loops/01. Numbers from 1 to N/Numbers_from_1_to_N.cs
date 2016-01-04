using System;

namespace _01.Numbers_from_1_to_N
{
    class Numbers_from_1_to_N
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            while(x <= n){
                Console.Write(x + " ");
                x++;
            }
        }
    }
}
