using System;

namespace Lab_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%3 == 0 || num%7 == 0)
            {
                Console.WriteLine("True");
            }else{
                Console.WriteLine("False");
            }
        }
    }
}
