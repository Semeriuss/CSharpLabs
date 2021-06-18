using System;
using static System.Console;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("First number: ");
            var num1 = Convert.ToDouble(ReadLine());
            Write("Second number: ");
            var num2 = Convert.ToDouble(ReadLine());

            var temp = num1;
            num1 = num2;
            num2 = temp;

            WriteLine("After Swapping");
            WriteLine($"First number {num1}");
            WriteLine($"Second number {num2}");
            Read();
        }
    }
}
