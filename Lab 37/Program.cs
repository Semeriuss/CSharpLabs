using System;

namespace Lab_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Data: ");
            string str = Console.ReadLine();
            Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
        }
    }
}
