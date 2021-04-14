using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the perimeter and area of a circle");

            Console.Write("Enter radius: ");
            double rad = double.Parse(Console.ReadLine());

            double perimeter = 2*rad*Math.PI;
            double area = Math.PI * Math.Pow(rad, 2);

            string formatted_perimeter = String.Format("{0:0.##}", perimeter);
            string formatted_area = String.Format("{0:0.##}", area);

            Console.WriteLine($"The Perimeter is {formatted_perimeter}\nThe Area is {formatted_area}");
            
        }
    }
}
