using System;

namespace _11.Number_as_Words
{
    class Number_as_Words
    {
        static void Main()
        {
            // ЛЕЛЕ КЪДЕ СЕ ЗАБЪРКАХ ,отказавм се

            int number = int.Parse(Console.ReadLine());

            if (number >= 100 && number < 1000)
            {
                int a = number / 100;
                int b = (number - a * 100) / 10;
                int c = (number - (a * 100 + b * 10));

                //Console.WriteLine($"{a}{b}{c}");

                switch (a)
                {

                    case 1:
                        #region second number
                        switch (b)
                        {
                            case 0:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and one");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and two");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and three");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and four");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and five");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and six");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and nine");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                break;
                            case 1:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred and ten");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and eleven");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and twelve");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and thirteen");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and fourteen");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and fifteen");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and sixteen");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and seveneen");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and eighteen");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and nineteen");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion

                                break;
                            case 2:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred and twenty");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and twenty-one");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and twenty-two");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and twenty-three");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and twenty-four");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and twenty-five");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and twenty-six");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and twenty-seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and twenty-eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and twenty-nine");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                break;
                            case 3:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred and twenty");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and twenty-one");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and twenty-two");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and twenty-three");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and twenty-four");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and twenty-five");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and twenty-six");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and twenty-seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and twenty-eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and twenty-nine");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                break;
                            case 4:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred and twenty");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and twenty-one");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and twenty-two");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and twenty-three");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and twenty-four");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and twenty-five");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and twenty-six");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and twenty-seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and twenty-eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and twenty-nine");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                break;
                            case 5:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred and twenty");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and twenty-one");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and twenty-two");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and twenty-three");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and twenty-four");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and twenty-five");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and twenty-six");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and twenty-seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and twenty-eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and twenty-nine");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                break;
                            case 6:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred and twenty");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and twenty-one");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and twenty-two");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and twenty-three");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and twenty-four");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and twenty-five");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and twenty-six");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and twenty-seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and twenty-eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and twenty-nine");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                break;
                            case 7:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred and twenty");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and twenty-one");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and twenty-two");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and twenty-three");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and twenty-four");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and twenty-five");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and twenty-six");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and twenty-seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and twenty-eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and twenty-nine");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                break;
                            case 8:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred and twenty");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and twenty-one");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and twenty-two");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and twenty-three");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and twenty-four");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and twenty-five");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and twenty-six");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and twenty-seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and twenty-eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and twenty-nine");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                break;
                            case 9:
                                #region third number
                                switch (c)
                                {
                                    case 0:
                                        Console.WriteLine("one hundred and twenty");
                                        break;
                                    case 1:
                                        Console.WriteLine("one hundred and twenty-one");
                                        break;
                                    case 2:
                                        Console.WriteLine("one hundred and twenty-two");
                                        break;
                                    case 3:
                                        Console.WriteLine("one hundred and twenty-three");
                                        break;
                                    case 4:
                                        Console.WriteLine("one hundred and twenty-four");
                                        break;
                                    case 5:
                                        Console.WriteLine("one hundred and twenty-five");
                                        break;
                                    case 6:
                                        Console.WriteLine("one hundred and twenty-six");
                                        break;
                                    case 7:
                                        Console.WriteLine("one hundred and twenty-seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("one hundred and twenty-eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("one hundred and twenty-nine");
                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;
                    case 2:
                        #region second number
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("two hundred and ");
                                break;
                            case 2:
                                Console.WriteLine("two hundred and twenty");
                                break;
                            case 3:
                                Console.WriteLine("two hundred and thirty");
                                break;
                            case 4:
                                Console.WriteLine("two hundred and forty");
                                break;
                            case 5:
                                Console.WriteLine("two hundred and fifty");
                                break;
                            case 6:
                                Console.WriteLine("two hundred and sixty");
                                break;
                            case 7:
                                Console.WriteLine("two hundred and seventy");
                                break;
                            case 8:
                                Console.WriteLine("two hundred and eighty");
                                break;
                            case 9:
                                Console.WriteLine("two hundred and ninety");
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;
                    case 3:
                        #region second number
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("three hundred and ");
                                break;
                            case 2:
                                Console.WriteLine("three hundred and twenty");
                                break;
                            case 3:
                                Console.WriteLine("three hundred and thirty");
                                break;
                            case 4:
                                Console.WriteLine("three hundred and forty");
                                break;
                            case 5:
                                Console.WriteLine("three hundred and fifty");
                                break;
                            case 6:
                                Console.WriteLine("three hundred and sixty");
                                break;
                            case 7:
                                Console.WriteLine("three hundred and seventy");
                                break;
                            case 8:
                                Console.WriteLine("three hundred and eighty");
                                break;
                            case 9:
                                Console.WriteLine("three hundred and ninety");
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;
                    case 4:
                        #region second number
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("four hundred and ");
                                break;
                            case 2:
                                Console.WriteLine("four hundred and twenty");
                                break;
                            case 3:
                                Console.WriteLine("four hundred and thirty");
                                break;
                            case 4:
                                Console.WriteLine("four hundred and forty");
                                break;
                            case 5:
                                Console.WriteLine("four hundred and fifty");
                                break;
                            case 6:
                                Console.WriteLine("four hundred and sixty");
                                break;
                            case 7:
                                Console.WriteLine("four hundred and seventy");
                                break;
                            case 8:
                                Console.WriteLine("four hundred and eighty");
                                break;
                            case 9:
                                Console.WriteLine("four hundred and ninety");
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;
                    case 5:
                        #region second number
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("five hundred and ");
                                break;
                            case 2:
                                Console.WriteLine("five hundred and twenty");
                                break;
                            case 3:
                                Console.WriteLine("five hundred and thirty");
                                break;
                            case 4:
                                Console.WriteLine("five hundred and forty");
                                break;
                            case 5:
                                Console.WriteLine("five hundred and fifty");
                                break;
                            case 6:
                                Console.WriteLine("five hundred and sixty");
                                break;
                            case 7:
                                Console.WriteLine("five hundred and seventy");
                                break;
                            case 8:
                                Console.WriteLine("five hundred and eighty");
                                break;
                            case 9:
                                Console.WriteLine("five hundred and ninety");
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;
                    case 6:
                        #region second number
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("six hundred and ");
                                break;
                            case 2:
                                Console.WriteLine("six hundred and twenty");
                                break;
                            case 3:
                                Console.WriteLine("six hundred and thirty");
                                break;
                            case 4:
                                Console.WriteLine("six hundred and forty");
                                break;
                            case 5:
                                Console.WriteLine("six hundred and fifty");
                                break;
                            case 6:
                                Console.WriteLine("six hundred and sixty");
                                break;
                            case 7:
                                Console.WriteLine("six hundred and seventy");
                                break;
                            case 8:
                                Console.WriteLine("six hundred and eighty");
                                break;
                            case 9:
                                Console.WriteLine("six hundred and ninety");
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;
                    case 7:
                        #region second number
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("seven hundred and ");
                                break;
                            case 2:
                                Console.WriteLine("seven hundred and twenty");
                                break;
                            case 3:
                                Console.WriteLine("seven hundred and thirty");
                                break;
                            case 4:
                                Console.WriteLine("seven hundred and forty");
                                break;
                            case 5:
                                Console.WriteLine("seven hundred and fifty");
                                break;
                            case 6:
                                Console.WriteLine("seven hundred and sixty");
                                break;
                            case 7:
                                Console.WriteLine("seven hundred and seventy");
                                break;
                            case 8:
                                Console.WriteLine("seven hundred and eighty");
                                break;
                            case 9:
                                Console.WriteLine("seven hundred and ninety");
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;
                    case 8:
                        #region second number
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("eight hundred and ");
                                break;
                            case 2:
                                Console.WriteLine("eight hundred and twenty");
                                break;
                            case 3:
                                Console.WriteLine("eight hundred and thirty");
                                break;
                            case 4:
                                Console.WriteLine("eight hundred and forty");
                                break;
                            case 5:
                                Console.WriteLine("eight hundred and fifty");
                                break;
                            case 6:
                                Console.WriteLine("eight hundred and sixty");
                                break;
                            case 7:
                                Console.WriteLine("eight hundred and seventy");
                                break;
                            case 8:
                                Console.WriteLine("eight hundred and eighty");
                                break;
                            case 9:
                                Console.WriteLine("eight hundred and ninety");
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;
                    case 9:
                        #region second number
                        switch (b)
                        {
                            case 1:
                                Console.WriteLine("nine hundred and ");
                                break;
                            case 2:
                                Console.WriteLine("nine hundred and twenty");
                                break;
                            case 3:
                                Console.WriteLine("nine hundred and thirty");
                                break;
                            case 4:
                                Console.WriteLine("nine hundred and forty");
                                break;
                            case 5:
                                Console.WriteLine("nine hundred and fifty");
                                break;
                            case 6:
                                Console.WriteLine("nine hundred and sixty");
                                break;
                            case 7:
                                Console.WriteLine("nine hundred and seventy");
                                break;
                            case 8:
                                Console.WriteLine("nine hundred and eighty");
                                break;
                            case 9:
                                Console.WriteLine("nine hundred and ninety");
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
