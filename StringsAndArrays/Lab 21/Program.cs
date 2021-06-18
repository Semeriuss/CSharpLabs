using System;
using static System.Console;

namespace Lab_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Write("Enter an integer: ");
            num1 = Convert.ToInt32(ReadLine());
            Write("Enter another integer: ");
            num2 = Convert.ToInt32(ReadLine());

            if(num1 == 20 || num2 == 20 || num1 + num2 == 20)
            {
                WriteLine(true);
            }else{
                WriteLine(false);
            }
        }
    }
}
