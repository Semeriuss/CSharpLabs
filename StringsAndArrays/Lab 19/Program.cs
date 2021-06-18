using System;
using static System.Console;

namespace Lab_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter first number: ");
            int num1 = Convert.ToInt32(ReadLine());
            Write("Enter second number: ");
            int num2 = Convert.ToInt32(ReadLine());

            if(num1 == num2){
                Write("Triple of sum is: {0}", (3*(num1+num2)));
            }else{
                WriteLine("The sum is {0}", (num1 + num2));
            }
            Read();
        }
    }
}
