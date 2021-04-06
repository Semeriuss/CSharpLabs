using System;
using static System.Console;

namespace Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "w3resource";
            Console.WriteLine(remove_char(test, 1));
            Console.WriteLine(remove_char(test, 9));
            Console.WriteLine(remove_char(test, 0));   
        }

        static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
