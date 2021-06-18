using System;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check type of input");

            Console.Write("Enter string: ");
            char chr = char.Parse(Console.ReadLine());

            if ((chr == 'a') || (chr == 'e') || (chr == 'i') || (chr == 'o') || (chr == 'u'))
            {
                Console.WriteLine("It is a lowercase vowel");
            }
            else if ((chr >= '0') && (chr <= '9'))
            {
                Console.WriteLine("It is a digit");
            }
            else
            {
                Console.WriteLine("It is a symbol");
            }
        }
    }
}
