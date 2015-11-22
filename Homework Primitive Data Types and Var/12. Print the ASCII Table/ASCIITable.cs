using System;
using System.Text;

namespace PrintTheASCIITable
{
    class ASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.GetEncoding(1252);
            for (byte i = 0; i < 255; i++)
            {
                Console.Write("{0} ", (char)i);
            }     
        }
    }
}