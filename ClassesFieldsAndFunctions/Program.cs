using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFieldsAndFunctions
{
    internal class Program
    {
        class Person
        {
            //public string Name;
            //public int Age;

            public string Name;
            public int Age;
            //now we can't access the fields directly, we need to use properties

            public void SetName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    Name = name;
                }
                else
                {
                    this.Name = "Unknown";
                }
            }
            
            //public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Unknown";
            //this points to the parameter of the function and not the field of the class

            public string GetName()
            {
                return Name;
            }

            public void SetAge(int age)
            {
                if (age > 0)
                {
                    Age = age;
                }
                else
                {
                    this.Age = 0;
                }
            }

            public int GetAge() => Age;

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("John", 25);
            Console.WriteLine(person.ReturnDetails());

            person.Name = "Jane";

            person.SetName("Tonny");
            person.SetAge(30);
            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine(person.GetAge());

            Console.ReadLine();

        }
    }
}
