using System;

namespace _09.Play_with_Int_Double_and_String
{
    class Play_with_Int_Double_and_String
    {
        static void Main()
        {
            Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string");
            int question = int.Parse(Console.ReadLine());
            switch (question)
            {
                case 1:
                    Console.WriteLine("Please enter a int:");
                    int resultInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(++resultInt);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double:");
                    double resultDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine(++resultDouble);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string:");
                    string resultString = Console.ReadLine();
                    Console.WriteLine(resultString+"*");
                    break;
                default:
                    break;
            }
        }
    }
}
