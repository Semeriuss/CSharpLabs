using System;
using static System.Console;

namespace Lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the temperature in Celcius: ");
            double num = Convert.ToDouble(ReadLine());
            double kelvin = num + 273;
            double fahrenheit = (9*num)/5 + 32;
            WriteLine("Kelvin = {0}", kelvin);
            WriteLine("Fahrenheit = {0}", fahrenheit);
        }
    }
}
