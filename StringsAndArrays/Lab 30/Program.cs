using System;
using System.Collections.Generic;

namespace Lab_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a hex number: ");
            string hex = Console.ReadLine();
            Console.WriteLine("Hexadecimal number: " + hex);

            int dec = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("Convert to-");
            Console.WriteLine("Decimal number: " + dec);
        }
    }
}
