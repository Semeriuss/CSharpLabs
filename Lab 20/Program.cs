using System;
using static System.Console;

namespace Lab_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int num3;
            Write("Enter first integer: ");
            int num1 = Convert.ToInt32(ReadLine());
            Write("Enter second integer: ");
            int num2 = Convert.ToInt32(ReadLine());
            num3 = num1 - num2;
            if(num1>num2){
                WriteLine("The double absolute value is : {0}", 2*Math.Abs(num3));                
            }else{
                WriteLine("The absolute value is : {0}", Math.Abs(num3));                
            }
            Read();
        }
    }
}
