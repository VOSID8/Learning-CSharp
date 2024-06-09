using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = 25; //infers int
            var bigNumber = 90000000000000000;

            var name = "John";
            //infers string

            var isTrue = true;
            //infers bool

            var negative = -98.20;
            //infers double

            //only use var when the type is obvious
            //var is not a type, it is a keyword

        }
    }
}
