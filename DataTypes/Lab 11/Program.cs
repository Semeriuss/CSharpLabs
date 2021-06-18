using System;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to Binary");

            int dec;
            string bin = String.Empty;
            
            Console.Write("Enter decimal number: ");
            dec = int.Parse(Console.ReadLine());

            do
            {
                bin += dec%2;
                dec/=2;
                
            }while(dec>0);

             Console.Write($"The number in binary form is ");
            for(int i = bin.Length-1; i>=0; i--)
            {
                Console.Write($"{bin[i]}");
                
            }
            
        }
    }
}
