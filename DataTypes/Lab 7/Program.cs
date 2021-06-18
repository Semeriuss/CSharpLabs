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

            Console.Write("Input time (hr): ");
            double hour = double.Parse(Console.ReadLine());
            Console.Write("Input time (min): ");
            double minutes = double.Parse(Console.ReadLine());
            Console.Write("Input time (sec): ");
            double seconds = double.Parse(Console.ReadLine());

            double toHour = hour + (minutes/60) + (seconds/3600);
            double inKilometersPerHour = (distance/1000)/toHour;
            double inMilesPerHour = inKilometersPerHour/3.6;

            Console.WriteLine($"The Speed is: {inKilometersPerHour} km/hr");
            Console.WriteLine($"The Speed is: {inMilesPerHour} mi/hr");
        }
    }
}
