using System;
using System.Linq;

namespace _03.Check_for_a_Play_Card
{
    class Check_for_a_Play_Card
    {
        static void Main()
        {
            string card = Console.ReadLine();
            if (new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" }.Contains(card))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
