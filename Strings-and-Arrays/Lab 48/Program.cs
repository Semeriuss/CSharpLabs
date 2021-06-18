using System;

namespace Lab_48
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            if(nums.Length > 1 && nums[0] == nums[nums.Length-1]) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}
