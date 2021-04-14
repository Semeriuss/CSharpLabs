using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Speed");

            Console.Write("Input distance (m): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Input time (s): ");
            double time = double.Parse(Console.ReadLine());

            Console.WriteLine($"The Speed is: {distance/time} m/s");
            
        }
    }
}
