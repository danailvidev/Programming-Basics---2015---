using System;

namespace Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 5, b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //big logic
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(new string('=', 30));
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
