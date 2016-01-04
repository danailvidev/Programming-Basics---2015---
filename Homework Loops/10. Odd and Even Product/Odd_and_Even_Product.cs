using System;

namespace _10.Odd_and_Even_Product
{
    class Odd_and_Even_Product
    {
        //You are given n integers(given in a single line, separated by a space). Write a program that checks whether 
        //the product of the odd elements is equal to the product of the even elements.Elements are counted from 1 to n, 
        //so the first element is odd, the second is even, etc.
        static void Main()
        {
            string numbers = Console.ReadLine();
            string[] input = numbers.Split(' ');
            int sumOdd = 1;
            int sumEven = 1;
            int index = 1;
            foreach (var item in input)
            {
                index++;
                int number = Int32.Parse(item);
                if (index % 2 == 0)
                {
                    sumOdd *= number;
                }
               else
                {
                    sumEven *= number;
                }
                    
               
            }
            if (sumOdd == sumEven)
            {
                Console.WriteLine("yes\nproduct = " + sumOdd);
            }
            else
            {
                Console.WriteLine("no\n" + "odd_product = "+ sumOdd + "\neven_product = " + sumEven);
            }
        }
    }
}
