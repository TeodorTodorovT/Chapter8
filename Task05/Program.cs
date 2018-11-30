using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that converts a binary number to decimal one
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} to decimal is {1}.",
                binary, Convert.ToInt64(binary, 2));
            Console.ReadLine();
        }
    }
}
