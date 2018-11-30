using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that converts a decimal number to binary one.
            Console.Write("Enter decimal number: ");
            int deci = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} to binary is {1}.",deci, Convert.ToString(deci, 2));
            Console.ReadLine();
        }
    }
}
