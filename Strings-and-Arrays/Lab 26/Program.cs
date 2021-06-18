using System;
using static System.Console;

namespace Lab_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = 0;
            int count = 1;
            int sum = 0;
            while(range<500)
            {
                if(isPrime(count))
                {
                    sum += count;
                    range++;
                }
                count+=1;
            }
            WriteLine(sum);
        }

        public static bool isPrime(int num)
        {
            if(num == 1)
            {
                return false;
            }
            for (int i = 2; i<=num/2; i++)
            {
                if(num%i == 0){
                    return false;
                }
            }
            return true;
        }
    }
}
