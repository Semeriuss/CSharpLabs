using System;

namespace Lab_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(Math.Abs(num1) <= 10 && Math.Abs(num2) <= 10)
            {
                Console.WriteLine("True");
            }else{
                Console.WriteLine("False");
            }
        }
    }
}
