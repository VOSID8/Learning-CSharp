using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_StoringUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Define a variable to hold your name
             * Define a variable to hold your phone number
             * Hold age
             * Print variables line by line
             * Define variables using var keyword
             */
            string name = "Siddharth";
            int age = 21;
            int phoneNumber = 01234567890;
            //with int, we can't store 0 in the beginning of the number,
            //so we can use string to store the phone number
            var age2 = 21
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Phone Number: " + phoneNumber);
        }
    }
}
