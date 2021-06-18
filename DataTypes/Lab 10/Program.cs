using System;

namespace Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check Parity");

            Console.Write("Enter number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter number: ");
            double num2 = double.Parse(Console.ReadLine());

            if((Math.Abs(num1-num2))%2==0)
            {
                Console.WriteLine(false);   
            }
            else
            {
                Console.WriteLine(true);
                
            }
        }
    }
}
