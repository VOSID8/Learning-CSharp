using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {

        struct Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        static void Main(string[] args)
        {

            //string name = "John";
            //int age = 30;

            Person person1;

            person1.Name = "John";
            person1.Age = 30;

            ReturnPerson(ref person1.Name, ref person1.Age);
            Console.WriteLine($"{person1.Name} - {person1.Age}");

            Person person2  = ReturnPerson2();

            Console.WriteLine($"{person2.Name} - {person2.Age}");

            Console.ReadLine();
        }

        static void ReturnPerson(ref string name, ref int age)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

        }

        static Person ReturnPerson2() 
        {
            Person person = new Person();
            Console.Write("Enter your name: ");
            person.Name = Console.ReadLine();

            Console.Write("Enter your age: ");
            person.Age = Convert.ToInt32(Console.ReadLine());

            return person;
        }
    }
}
