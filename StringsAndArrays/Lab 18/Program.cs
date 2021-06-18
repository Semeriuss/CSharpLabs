using System;

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive: {0}", num*num2<0);
        }
    }
}
