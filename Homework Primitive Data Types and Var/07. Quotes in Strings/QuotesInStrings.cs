﻿using System;

namespace _07.Quotes_in_Strings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string a = "The \"use\" of quotations causes difficulties.";
            string b = @"The ""use"" of quotations causes difficulties."; 
            Console.WriteLine("{0}\n{1}",a,b);
        }
    }
}