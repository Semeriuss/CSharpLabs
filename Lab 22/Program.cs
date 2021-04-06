using System;
using static System.Console;

namespace Lab_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Write("Enter an integer: ");
            num = Convert.ToInt32(ReadLine());
            WriteLine(checker(num));            
        }

        public static bool checker(int num)
        {
            if(Math.Abs(num -100) <= 20 || Math.Abs(num - 200) <= 20)
            {
                return true;
            }return false;
            

        }
    }
}
