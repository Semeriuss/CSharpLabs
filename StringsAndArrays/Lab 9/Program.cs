using System;
using static System.Console;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, average;
            Write("Enter the first number: ");
            num1 = Convert.ToInt32(ReadLine());
            Write("Enter the second number: ");
            num2 = Convert.ToInt32(ReadLine());
            Write("Enter the third number: ");
            num3 = Convert.ToInt32(ReadLine());
            Write("Enter the fourth number: ");
            num4 = Convert.ToInt32(ReadLine());

            average = (num1 + num2 + num3 + num4)/4;

            WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is: {average}");
        }
    }
}
