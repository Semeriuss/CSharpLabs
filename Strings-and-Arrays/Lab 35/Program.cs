using System;

namespace Lab_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number (<100): ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number(>200): ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1<100 && num2>200)
            {
                Console.WriteLine("True");
            }else{
                Console.WriteLine("False");
            }
        }
    }
}
