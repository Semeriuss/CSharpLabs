using System;

namespace Lab_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Test Data: ");
            string str = Console.ReadLine();
            var result = "";

            if (str.Length >= 1 && str[0] == 'P') 
                result += str[0];
            if (str.Length >= 2 && str[1] == 'H')
                result += str[1];
            Console.WriteLine(result);
        }
    }
}
