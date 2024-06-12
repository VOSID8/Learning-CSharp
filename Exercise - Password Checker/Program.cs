using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter password again: ");
            string passwordC = Console.ReadLine();

            if(!password.Equals(string.Empty) && !passwordC.Equals(string.Empty))
            {
                if(password.Equals(passwordC))
                {
                    Console.WriteLine("Password is correct");
                }
                else
                {
                    Console.WriteLine("Password is incorrect");
                }
            }
            else
            {
                Console.WriteLine("Please enter password");
            }

        }
    }
}
