using System;

namespace _02.Bonus_Score
{
    class Bonus_Score
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            
            if (num >= 1 && num <= 3)
            {
                Console.WriteLine(num*10);
            }
            else if (num >= 6 && num <= 6)
            {
                Console.WriteLine(num * 100);
            }
            else if (num >= 7 && num <= 9)
            {
                Console.WriteLine(num * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
