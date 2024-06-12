using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5,5));
            Console.WriteLine(Add2(5));

            string nameInput = "aba";
            int ageInput = 20;
            string addressInput = "1 something road";

            PrintDetails(nameInput, ageInput, addressInput);

            int num = ReadInt("number");

            List<string> shoppingList = new List<string>
            {
                "apple",
                "banana",
                "orange"
            };
            Console.WriteLine(shoppingList.IndexOf("Milk"));

            if (findInList(shoppingList,"apple",out int index))
            {
                Console.WriteLine($"Found at {index}");
            }
            else
            {
                Console.WriteLine("Not found");
            }
            num = 20;

            AssignValue(ref num);

            Console.WriteLine($"Your new num is {num}");

            //ref parameters are used to pass a reference to a variable

            //Console.WriteLine(found ? "Found" : "Not found");

            Console.ReadLine();
        }

        static int ReadInt(string message)
        {
            Console.WriteLine("Enter a " + message + ": ");
            return int.Parse(Console.ReadLine());
        }

        static int ReadString(string message)
        {
            Console.WriteLine("Enter a " + message + ": ");
            return int.Parse(Console.ReadLine());
        }

        static int Add(int a,int b)
        {
            return a+b;
        }

        static int Add2(int a, int b = 10)
        {
            return a + b;
        }

        static bool findInList(List<string> shoppingList, string item, out int index)
        {
            index = -1;

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i] == item)
                {
                    index = i;
                }
                //if (shoppingList[i].ToLower().Equals(shoppingList.ToLower())))
                //    index = i;
                //}
            }
            return index > -1;
        }

        static void PrintDetails(string name,int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }

        static void test(int num)
        {
            num = 5;
            Console.WriteLine($"num = {num}");
        }

        static bool TryParse(string s,out int result)
        {
            result = 0;
            return true;
        }

        //reference parameters

        static void AssignValue(ref int num)
        {
            num = 5;
        }

        

    }
}
