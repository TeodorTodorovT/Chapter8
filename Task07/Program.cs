using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that converts a hexadecimal number to decimal one.
            Console.Write("Enter hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to decimal is {1}.",hexa, Convert.ToInt32(hexa, 16));
            Console.ReadLine();
        }
    }
}
