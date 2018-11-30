using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that converts a hexadecimal number to binary one. 
            Console.Write("Enter hexadecimal number: ");
            string hexa = Console.ReadLine();
            Console.WriteLine("{0} to binary is {1}.",hexa, Convert.ToString(Convert.ToInt32(hexa, 16), 2));
            Console.ReadLine();
        }
    }
}
