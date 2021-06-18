using System;

namespace Lab_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((Math.Abs(num1-20)<Math.Abs(num2-20)) ? num1 : (Math.Abs(num1-20)==Math.Abs(num2-20)) ? 0 : 1);
        }
    }
}
