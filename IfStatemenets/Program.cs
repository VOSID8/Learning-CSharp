using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatemenets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 22;
            string name = "John";

            if (age == 22)
            {
                Console.WriteLine("wow you are 22");
            }
            //with int you can use >=, <=, ==, !=, >, <
            //with string you can use ==, !=
            if(name == "John" || age>=22)
            {
                Console.WriteLine("wow your name is John and so big");
            }
            else if (name == "John" && age <22)
            {
                Console.WriteLine("you are not John or something");
            }
            else
            {
                Console.WriteLine("you are not John");
            }

            string xInput = Console.ReadLine();
            int x = Convert.ToInt32(xInput);

            string yInput = Console.ReadLine();
            int y = Convert.ToInt32(yInput);

            string ansInput = Console.ReadLine();
            int ans = Convert.ToInt32(ansInput);

            if (x + y == ans)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.ReadLine();
        }
    }
}
