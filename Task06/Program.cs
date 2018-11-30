using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that converts a decimal number to hexadecimal one.
            Console.Write("Enter decimal number: ");
            int deci = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} to hexadecimal is {1}.",deci, deci.ToString("X"));
            Console.ReadLine();
        }
    }
}
