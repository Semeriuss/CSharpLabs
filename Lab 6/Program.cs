using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display values of a function");
            
            double x;

            for(int y = -5; y < 6; y++)
            {
                Console.WriteLine($"{Math.Pow(y, 2) + 2*y + 1}");
            }
        }
    }
}
