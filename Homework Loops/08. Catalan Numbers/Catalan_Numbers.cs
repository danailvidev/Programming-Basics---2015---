using System;

namespace _08.Catalan_Numbers
{
    class Catalan_Numbers
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double factorielA = 1;
            double factorielB = 1;
            double factorielC = 1;
            for (int i = 1; i <= n * 2; i++)
            {
                factorielA *= i;
            }
            for (int i = 1; i <= n + 1; i++)
            {
                factorielB *= i;
            }
            for (int i = 1; i <= n ; i++)
            {
                factorielB *= i;
            }
            Console.WriteLine(factorielA/(factorielB* factorielC));
        }
    }
}
