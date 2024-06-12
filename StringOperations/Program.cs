using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aba";
            int age = 23;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();

            //string formatting
            Console.WriteLine("Name: " + name + "\nAge: " + age);
            Console.WriteLine("Your name is {0} and age is {1}", name, age);

            Console.WriteLine("Name: {0}\nAge: {1}", name, age);

            //string interpolation
            Console.WriteLine($"Name: {name}\nAge: {age}");
            Console.WriteLine();

            //string concatenation
            string text = "Hello";
            string test = string.Concat(text, " World");

            string[] names = { "Aba", "Baba", "Caba" };

            string allNames = string.Join(",", names);
            
            Console.WriteLine(String.Concat("Your name is ",name," and your age is: ",age));

            string name2 = string.Empty;
            Console.Write("Enter your name: ");

            //string equals

            char[] chars = new char[] { 'A', 'B', 'C', 'D' };
            object newCompare = new string(chars);

            Console.WriteLine(newCompare.Equals("ABCD"));
            Console.WriteLine(newCompare == "ABCD");

            // == compares the reference of the object
            // Equals compares the value of the object


            Console.ReadLine();
        }
    }
}
