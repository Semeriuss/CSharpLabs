using System;
using static System.Console;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a digit: ");
            int num = Convert.ToInt32(ReadLine());
            for(int i = 0; i<2; i++)
            {
                for (int j = 0; j<=4; j++)
                {
                    Write("{0} ", num);   
                }
                WriteLine();
                for (int k = 0; k<=4; k++)
                {
                    Write("{0}", num);
                }
                WriteLine();
            }
        }
    }
}
