using System;

namespace _11.Number_as_Words_Second_try
{
    class Program
    {
        static void Main()
        {
            var edinici = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var desetici = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int number = int.Parse(Console.ReadLine());
            string words = "";

            if (number > 100)
            {
                words += edinici[number / 100] + " hundred ";
                number %= 100;
            }

            if (number < 20)
            {
                words += edinici[number];
                Console.WriteLine(words);
            }
            else
            {
                words += desetici[number / 10];
                words += "-" + edinici[number % 10];
                Console.WriteLine(words);

            }
        }
    }
}
