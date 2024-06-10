using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerbatimStringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //\t \n"
            string path = "C:\\Program Files\\Microsoft Visual Studio 10.0";
            Console.WriteLine(path);
            string speech = "\"Hello, World!\"";

            path = @"C:\Program Files\Microsoft Visual Studio 10.0";

            Console.WriteLine(path);

            string name = @"Hello ""someone"""; //Hello "someone"
            string name2 = "Hello \"someone\""; //Hello "someone"
            string name3 = "Hello \\someone\\"; //Hello \someone\
            string name4 = "Hello 'someone'"; //Hello 'someone'

            Console.WriteLine(path);
            Console.ReadLine();

        }
    }
}
