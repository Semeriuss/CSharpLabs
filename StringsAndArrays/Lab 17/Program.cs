using System;

namespace Lab_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createString("Hello World!"));
        }

        static string createString(string str)
        {
            string first = str.Substring(0,1);
            return first + str + first;
        }
    }
}
