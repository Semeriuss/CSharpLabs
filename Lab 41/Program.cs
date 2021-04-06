using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string (conatins at least one 'w' char) : ");
            string str = Console.ReadLine();
            var count = str.Count(s => s == 'w');
            Console.WriteLine("Test the string contains 'w' character  between 1 and 3 times: ");
            Console.WriteLine(count>=1 && count <= 3);  
        }
    }
}
