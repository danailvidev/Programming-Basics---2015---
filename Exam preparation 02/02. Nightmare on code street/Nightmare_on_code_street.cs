using System;

namespace _02.Nightmare_on_code_street
{
    class Nightmare_on_code_street
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int counter = 0;
            int sum = 0;
            int Oddnums = 0;
            foreach (var item in text)
            {
                if (counter % 2 == 1)
                {
                switch (item)
                {
                    case '0':
                        sum += 0;
                        Oddnums++;
                        break;
                    case '1':
                        sum += 1;
                        Oddnums++;
                        break;
                    case '2':
                        sum += 2;
                        Oddnums++;
                        break;
                    case '3':
                        sum += 3;
                        Oddnums++;
                        break;
                    case '4':
                        sum += 4;
                        Oddnums++;
                        break;
                    case '5':
                        sum += 5;
                        Oddnums++;
                        break;
                    case '6':
                        sum += 6;
                        Oddnums++;
                        break;
                    case '7':
                        sum += 7;
                        Oddnums++;
                        break;
                    case '8':
                        sum += 8;
                        Oddnums++;
                        break;
                    case '9':
                        sum += 9;
                        Oddnums++;
                        break;
                    default:
                        break;
                }
                    
                }
                counter += 1;
            }
            Console.WriteLine("{0} {1}", Oddnums,sum);
        }
    }
}
