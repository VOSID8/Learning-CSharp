using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Typecasting
            int a = 10;
            double b = a;
            Console.WriteLine("Implicit Typecasting: " + b);

            // Explicit Typecasting
            double c = 10.5;
            int d = (int)c;
            Console.WriteLine("Explicit Typecasting: " + d);

            // Typecasting using Convert class
            string e = "10";
            int f = Convert.ToInt32(e);
            Console.WriteLine("Typecasting using Convert class: " + f);

        }
    }
}
