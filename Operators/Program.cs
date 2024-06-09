using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine("Addition: " + c);
            c = a - b;
            Console.WriteLine("Subtraction: " + c);
            c = a * b;
            Console.WriteLine("Multiplication: " + c);
            c = a / b;
            Console.WriteLine("Division: " + c);
            c = a % b;
            Console.WriteLine("Modulus: " + c);

            // Relational Operators
            bool result = a == b;
            Console.WriteLine("Equal: " + result);
            result = a != b;
            Console.WriteLine("Not Equal: " + result);
            result = a > b;
            Console.WriteLine("Greater Than: " + result);
            result = a < b;
            Console.WriteLine("Less Than: " + result);
            result = a >= b;
            Console.WriteLine("Greater Than or Equal: " + result);
            result = a <= b;
            Console.WriteLine("Less Than or Equal: " + result);

            // Logical Operators
            bool x = true;
            bool y = false;
            result = x && y;
            Console.WriteLine("AND: " + result);
            result = x || y;
            Console.WriteLine("OR: " + result);
            result = !x;
            Console.WriteLine("NOT: " + result);

            // Bitwise Operators
            a = 5; // 0000 0101
            b = 10; // 0000 1010
            c = a & b; // 0000 0000
            Console.WriteLine("AND: " + c);
            c = a | b; // 0000 1111
            Console.WriteLine("OR: " + c);
            c = a ^ b; // 0000 1111
            Console.WriteLine("XOR: " + c);
            c = ~a; // 1111 1010
            Console.WriteLine("NOT: " + c);
            c = a << 1; // 0000 1010
            Console.WriteLine("Left Shift: " + c);
            c = a >> 1; // 0000 0010
            Console.WriteLine("Right Shift: " + c);

        }
    }
}
