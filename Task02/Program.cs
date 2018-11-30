using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.
            Console.WriteLine("1111010110011110 to decimal is {0}.",Convert.ToInt64("1111010110011110", 2));

            Console.WriteLine("1111010110011110 to hexadecimal is {0}.",Convert.ToInt64("1111010110011110", 2).ToString("X"));
            Console.ReadLine();
        }
    }
}
