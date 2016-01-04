using System;

namespace _04.Print_a_Deck_of_52_Cards
{
    class Print_a_Deck_of_52_Cards
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "9", "10", "J", "Q", "K", "A" };
            foreach (var card in cards)
            {
                Console.Write(card + "♣ ");
                Console.Write(card + "♦ ");
                Console.Write(card + "♥ ");
                Console.Write(card + "♠");
                Console.WriteLine();
            }
        }
    }
}
