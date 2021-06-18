using System;
using static System.Console;

namespace Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(swapChar("w3resource"));
            WriteLine(swapChar("Python"));
            WriteLine(swapChar("x"));
        }

        static string swapChar(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length-1) + str.Substring(1, str.Length-2) + str.Substring(0,1) : str;
        }
    }
}
