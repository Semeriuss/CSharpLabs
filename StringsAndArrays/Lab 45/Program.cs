using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nInput an integer:");  
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
            Console.Write("Number of " + x + " present in the said array: ");
            Console.WriteLine(nums.Count(n => n == x));
        }
    }
}
