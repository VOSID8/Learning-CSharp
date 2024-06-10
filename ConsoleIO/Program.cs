using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow my name is Siddharth");

            Console.ReadLine();
            string name;
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + " you are " + age + " years old");
            Console.ReadLine();

        }
    }
}
