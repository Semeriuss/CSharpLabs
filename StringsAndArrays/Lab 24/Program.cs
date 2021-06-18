using System;
using static System.Console;

namespace Lab_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter Test data: ");
            string str = ReadLine();
            
            WriteLine("Output: {0}", longest(str));
        }

        public static string longest(string str)
        {
            string[] stringArr = str.Split(new[] {" "}, StringSplitOptions.None);
            string key = stringArr[0];
            foreach(string st in stringArr)
            {
                if(key.Length < st.Length)
                {
                    key = st;
                }
            }
            return key;
        }
    }
}
