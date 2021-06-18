using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            
            int height = width;

            for(int i = 0; i <= height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine("");
                width--;
            }
        }
    }
}
