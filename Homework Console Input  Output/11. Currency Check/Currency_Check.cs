using System;

namespace _11.Currency_Check
{
    class Currency_Check

    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine()); //rubli
            double d = double.Parse(Console.ReadLine()); //dollars
            double e = double.Parse(Console.ReadLine()); //euro
            double b = double.Parse(Console.ReadLine()); //leva B
            double m = double.Parse(Console.ReadLine()); //leva M
            r = (r / 100) * 3.5;
            d = d * 1.5;
            e = e * 1.95;
            b = b / 2;
            double min1 = Math.Min(r, d);
            double min2 = Math.Min(e, b);
            double minFin = Math.Min(min1, min2);
            Console.WriteLine(minFin);           
        }
    }
}
