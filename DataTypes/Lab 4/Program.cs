using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operations + - * / %\n");

            Console.Write("Enter number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter operator: ");
            char oper = char.Parse(Console.ReadLine());

            Console.Write("Enter number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (oper)
            {
                case '+':
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;
                case '%':
                    Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                    break;
                default:
                    break;
            }
            
        }
    }
}
