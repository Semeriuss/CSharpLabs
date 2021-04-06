using System;

namespace Lab_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1,3,-5,4};
            int[] arr2 = {1,4,-5,-2};
            for(int i = 0; i<=arr1.Length-1; i++)
            {
                Console.Write(arr1[i]*arr2[i] + " ");
            }
        }
    }
}
