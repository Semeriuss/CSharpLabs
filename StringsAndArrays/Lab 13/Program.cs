using System;
using static System.Console;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a number: ");
            int num = Convert.ToInt32(ReadLine());
            for(int i = 0; i<3; i++)
            {
                Write("{0}", num);
            }
            WriteLine();
            for(int j = 0; j<3; j++)
            {
                for(int k = 0; k<2; k++)
                {
                    Write("{0} ", num);
                }
                WriteLine();
            }
            for(int i = 0; i<3; i++)
            {
                Write("{0}", num);
            }
            WriteLine();
        }
    }
}
