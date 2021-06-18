using System;

namespace Lab_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Output: {0}", reverse(input));
        }

        public static string reverse(string str)
        {
            string res = "";
            string[] st = str.Split(new[] {" "}, StringSplitOptions.None);
            for(int i = st.Length -1; i > -1; i--){
                //Console.Write($"{i} ");
                res += st[i] + " ";
            }
            return res;
        }
    }
}
