using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Calci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problem statement: Create a small calculator that can
            //perform arithmetic and bitwise operations

            Console.Write("Enter a number: ");
            string xInput = Console.ReadLine();
            int x = Convert.ToInt32(xInput);

            Console.Write("Enter another number: ");
            string yInput = Console.ReadLine();
            int y = Convert.ToInt32(yInput);

            Console.Write("Enter 1 for Arithemtic and 2 for Bitwise operations: ");
            string usei = Console.ReadLine();
            int useit = Convert.ToInt32(usei);
            
            if(useit == 1)
            {
                Console.Write("Enter 1 for addition," +
                        "2 for subtraction: " +
                        "3 for multiplication: ");
                string opInput = Console.ReadLine();
                int op;
                if (int.TryParse(opInput, out op))
                {
                    if (op == 1)
                    {
                        int c = x + y;
                        Console.WriteLine("After addition: " + c);
                    }
                    else if (op == 2)
                    {
                        int c = x - y;
                        Console.WriteLine("After subtraction: " + c);
                    }
                    else if (op == 3)
                    {
                        int c = x * y;
                        Console.WriteLine("After multiplication: " + c);
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation");
                    }
                }
                else
                {
                    Console.WriteLine("Enter number only");
                }
            }
            else if(useit == 2)
            {
                Console.Write("Enter 1 for AND," +
                        "2 for OR: " +
                        "3 for XOR: ");
                string opInput = Console.ReadLine();
                int op;
                if (int.TryParse(opInput, out op))
                {
                    if (op == 1)
                    {
                        int c = x & y;
                        Console.WriteLine("After AND: " + c);
                    }
                    else if (op == 2)
                    {
                        int c = x | y;
                        Console.WriteLine("After OR: " + c);
                    }
                    else if (op == 3)
                    {
                        int c = x ^ y;
                        Console.WriteLine("After XOR: " + c);
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation");
                    }
                }
                else
                {
                    Console.WriteLine("Enter number only");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            
            Console.ReadLine();
        }
    }
}
