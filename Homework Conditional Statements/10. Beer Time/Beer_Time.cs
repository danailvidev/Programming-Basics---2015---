using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Beer_Time
{
    class Beer_Time
    {
        static void Main()
        {
            string time = Console.ReadLine();
            string AMorPM = time.Substring(time.LastIndexOf(':') + 4);

            int index = time.IndexOf(":");
            int hours = int.Parse(time.Substring(0, index));

            switch (AMorPM)
            {
                case "AM":
                    if (hours < 3)
                    {
                        Console.WriteLine("beer time");
                    }
                    else
                    {
                        Console.WriteLine("non-beer time");
                    }
                    break;
                case "PM":
                    if (hours >= 1)
                    {
                        Console.WriteLine("beer time");
                    }
                    else
                    {
                        Console.WriteLine("non-beer time");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
       
    }
}
