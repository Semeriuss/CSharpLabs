using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the surface area and volume of a sphere");

            Console.Write("Enter radius: ");
            double rad = double.Parse(Console.ReadLine());

            double surface_area = 4*Math.PI * Math.Pow(rad, 2);
            double volume = 4/3 * Math.PI * Math.Pow(rad, 3);

            string formatted_surface_area = String.Format("{0:0.##}", surface_area);
            string formatted_volume = String.Format("{0:0.##}", volume);

            Console.WriteLine($"The Perimeter is {formatted_surface_area}\nThe Area is {formatted_volume}");
        }
    }
}
