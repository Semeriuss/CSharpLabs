using System;

namespace Lab_42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string str = Console.ReadLine();

            if(str.Length < 4){
                Console.WriteLine(str.ToUpper());
            }
            Console.WriteLine(str);
        }
    }
}
