using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_29
{
    class Program
    {
        public static void Main(string[] args)
        {
            FileInfo file = new FileInfo(@"C:\Users\semer\Documents\Academia\OOP II\Labs\Lab 29\abc.txt");
            Console.WriteLine("\nSize of file: " + file.Length.ToString());
        }
    }
}
