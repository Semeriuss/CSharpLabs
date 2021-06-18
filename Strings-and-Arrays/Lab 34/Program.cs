using System;

namespace Lab_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String: ");
            string str = Console.ReadLine();
            Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
        }
    }
}
