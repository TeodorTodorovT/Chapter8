using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and decimal numeral systems.
            conv("2A3E");
            conv("FA");
            conv("FFFF");
            conv("5A0E9");
            Console.ReadLine();
        }
        static void conv(string value)
        {
            Console.WriteLine("{0} to decimal is {1}.",
                value, Convert.ToInt32(value, 16));
            Console.WriteLine("{0} to decimal is {1}.\n", value,Convert.ToString(Convert.ToInt32(value, 16), 2));
        }


    }
}
