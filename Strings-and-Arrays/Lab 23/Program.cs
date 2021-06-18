using System;
using static System.Console;

namespace Lab_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Write("Enter a string: ");
            str = ReadLine();

            WriteLine("In lowercase: {0}", str.ToLower());
        }
    }
}
