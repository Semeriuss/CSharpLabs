using System;
using static System.Console;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Write("Enter the number: ");
            num = Convert.ToInt32(ReadLine());

            for(int i = 0; i<=10; i++)
            {
                WriteLine($"{num} * {i} = {num*i}");
            }
        }
    }
}
