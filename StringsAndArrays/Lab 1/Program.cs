using System;
using static System.Console;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input first number
            WriteLine("Enter first number");
            var num1 = ReadLine();
            //Input second number
            WriteLine("Enter second number");
            var num2 = ReadLine();
            //Display the results
            WriteLine("The sum is {0}", Convert.ToInt32(num1)+Convert.ToInt32(num2));
        }
    }
}
