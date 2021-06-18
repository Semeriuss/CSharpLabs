using System;
using static System.Console;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, res1, res2;
            Write("Enter first number ");
            num1 = Convert.ToInt32(ReadLine());
            Write("Enter second number ");
            num2 = Convert.ToInt32(ReadLine());
            Write("Enter third number ");
            num3 = Convert.ToInt32(ReadLine());
            
            res1 = (num1+num2)*num3;
            res2 = (num1*num2) + (num2*num3);

            WriteLine($"Result of specified numbers {num1}, {num2}, and {num3}, (x+y).z is {res1} and x.y + y.z is {res2}");

        }
    }
}
