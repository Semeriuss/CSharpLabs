using System;
using static System.Console;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Write("Input the first number to multiply: ");
            var num1 = ReadLine();
            Write("Input the second number to multiply: ");
            var num2 = ReadLine();
            Write("Input the third number to multiply: ");
            var num3 = ReadLine();
            result = Convert.ToInt32(num1) * Convert.ToInt32(num2) * Convert.ToInt32(num3);
            WriteLine($"{num1} x {num2} x {num3} = {result}");

        }
    }
}
