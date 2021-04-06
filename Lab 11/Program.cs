using System;
using static System.Console;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Write("Enter your age - ");
            age = Convert.ToInt32(ReadLine());
            WriteLine("You look older than {0}", age);
        }
    }
}
