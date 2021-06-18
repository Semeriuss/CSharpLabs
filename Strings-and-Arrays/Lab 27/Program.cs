using System;
using static System.Console;

namespace Lab_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number: ");
            int num = Convert.ToInt32(ReadLine());

            WriteLine("Sample Output: {0}", digitSum(num));
        }

        public static int digitSum(int num)
        {
            int store = 0;
            while(num>1)
            {
                store += num%10;
                num = num/10;
            }
            return store + num;
        }
    }
}
