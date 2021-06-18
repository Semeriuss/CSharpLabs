using System;
using static System.Console;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter first number");
            var num1 = ReadLine();
            WriteLine("Enter second number");
            var num2 = ReadLine();
            WriteLine($"The quotient is {Convert.ToDouble(num1) / Convert.ToDouble(num2)}");
        }
    }
}
