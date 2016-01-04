using System;

namespace _04.Print_a_Deck_of_52_Cards_v2
{
    class Print_a_Deck_of_52_Cards_v2
    {
        static void Main()
        {
            for (int card = 2; card < 15; card++)
            {
                for (int color = 0; color < 4; color++)
                {
                    switch (card)
                    {
                        case 2: Console.Write("2"); break;
                        case 3: Console.Write("3"); break;
                        case 4: Console.Write("4"); break;
                        case 5: Console.Write("5"); break;
                        case 6: Console.Write("6"); break;
                        case 7: Console.Write("7"); break;
                        case 8: Console.Write("8"); break;
                        case 9: Console.Write("9"); break;
                        case 10: Console.Write("10"); break;
                        case 11: Console.Write("J"); break;
                        case 12: Console.Write("Q"); break;
                        case 13: Console.Write("K"); break;
                        case 14: Console.Write("A"); break;
                    }
                    switch (color)
                    {
                        case 0: Console.Write('♠'); break;
                        case 1: Console.Write('♥'); break;
                        case 2: Console.Write('♣'); break;
                        case 3: Console.Write('♦'); break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
