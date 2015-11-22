using System;

namespace _06.Strings_and_Objects
{
    class StringsАndObjects
    {
        static void Main()
        {
            string a = "Hello",b = "World";
            object c = a +" " +b;
            string d = (string)c;
            Console.WriteLine(d);
        }
    }
}
