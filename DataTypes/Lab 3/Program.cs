using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Default username and password is: username and password\n");
            // Console.Write("Enter Username: ");
            // string username = Console.ReadLine();

            // Console.Write("Enter password: ");
            // string password = Console.ReadLine();
            
            int ctr = 0;
            bool success = false;

            
            do
            {
                Console.Write("Check Username: ");
                string userCheck = Console.ReadLine();

                Console.Write("Check password: ");
                string passCheck = Console.ReadLine();

                if(userCheck == "username" && passCheck == "password")
                {
                    ctr = 3;
                    Console.WriteLine("Login Successful");
                    
                }
                else
                {
                    ctr++;
                    success = true;
                    Console.WriteLine("Username or password is wrong! {0} attempts left", Math.Abs(3-ctr));
                }
            } while (ctr<3);
            if(!success)
            {
                Console.WriteLine("Login attempted more than three times unsuccessfully!");
            }
        }
    }
}
