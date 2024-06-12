using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        static string name = "Aba";
        static void Main(string[] args)
        {
            bool success = int.TryParse("123", out int result);
            //WelcomeMessage();
            //CreateAndPrintArray();
            PrintIntroduction();

            Console.Title = $"{ReturnName()}'s App";
            int[] numbers = new int[3];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }

            Console.ReadLine();

        }
        static string ReturnName()
        {
            return name;
        }

        static int ReadNumberFromConsole()
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            return number;
        }

        static void PrintIntroduction()
        {
            string name = ReturnName();
            Console.WriteLine("Hello, my name is " + name);
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome Aba");
        }

        static void WelcomeMessage(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        static void CreateAndPrintArray()
        {
            int[] numbers3 = new int[3] { 0, 1, 2 };

            foreach (int number in numbers3)
            {
                Console.Write($"{number} ");
            }
        }


    }
}
