using System;

namespace Lab_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();
            var result = string.Empty;
            for(int i = 0; i<str.Length; i++)
            {
                if (i % 2 == 0) result += str[i];
            }
            Console.WriteLine(result);
        }
    }
}
