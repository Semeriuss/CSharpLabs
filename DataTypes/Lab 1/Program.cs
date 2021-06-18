using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            for(int i = 0; i<3; i++)
            {
                Console.Write("Enter letter: ");
                input += Convert.ToChar(Console.ReadLine());
            }
            
            for(int j=input.Length-1; j>=0; j--)
            {
                Console.Write(input[j] + " ");
            }
        }
    }
}
