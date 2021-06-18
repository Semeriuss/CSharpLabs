using System;

namespace Lab_55
{
    class Program
    {
        public static int centuryFromYear(int year)
        {
            return (int)(year / 100) + ((year % 100 == 0) ? 0 : 1);
        }

        public static void Main()
        {
            Console.WriteLine(centuryFromYear(1799) == 18);
            Console.WriteLine(centuryFromYear(1900) == 19);
            Console.WriteLine(centuryFromYear(1901) == 19);
            Console.WriteLine(centuryFromYear(1901) == 20);
            Console.WriteLine(centuryFromYear(1806) == 19);
            Console.WriteLine(centuryFromYear(1568) == 20);
            Console.WriteLine(centuryFromYear(2010) == 21);
        }
    }
}
