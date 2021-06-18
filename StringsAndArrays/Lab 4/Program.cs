using System;
using static System.Console;
using System.Data;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            WriteLine("Enter expression followed by q");
            var expression = ReadLine();
            var value = dt.Compute(expression, "");
            WriteLine($"Result is {Convert.ToInt16(value)}");
        }
    }
}
