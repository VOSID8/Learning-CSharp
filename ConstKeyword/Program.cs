using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vat = 20;
            vat = 10;

            const int vat2 = 20;
            // vat2 = 10; // Error: A const field cannot be assigned to (except in a static constructor or a variable initializer)
            const double percentVAT = vat2 / 1000;


            Console.WriteLine(vat /1000);

        }
    }
}
