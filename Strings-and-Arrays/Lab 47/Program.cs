using System;

namespace Lab_47
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
            var sum = 0;
            foreach(int num in nums)
            {
                sum+=num;
            }
            Console.WriteLine(sum);
        }
    }
}
