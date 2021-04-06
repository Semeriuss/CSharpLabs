using System;

namespace Lab_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third integer: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int[] numArr = {num1, num2, num3};
            int max = num1;
            int min = num1;
            foreach(int i in numArr)
            {
                if(max < i)
                {
                    max = i;
                }
                if(min > i)
                {
                    min = i;
                }
            }
            Console.WriteLine("Largest of three: {0}", max);
            Console.WriteLine("Lowest of three: {0}", min);
        }
    }
}
