using System;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that converts a binary number to hexadecimal one.
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("{0} to hexadecimal is {1}.",binary, Convert.ToInt32(binary, 2).ToString("X"));
            Console.ReadLine();
        }
    }
}
