using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToString
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            //public override string ToString()
            //{
            //    return "Name: " + name + " Age: " + age;
            //}

            public string ReturnDetails()
            {
                return "Name: " + name + " Age: " + age;
            }
            public override string ToString()
            {
                return "Name: " + name + " Age: " + age;
                //return ReturnDetails();
            }
            public override bool Equals(object obj)
            {
                Person person = (Person)obj;
                return name.Equals(person.name) && age == person.age;
                //here we have to cast the object to Person
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("John", 25);
            Console.WriteLine(person.ReturnDetails());
            //what if you wanna just keep it as Console.WriteLine(person);
            //Console.WriteLine(person.ToString());
            Console.WriteLine(person);
            //here on the console it will show the same output as above
            //ToString method is called implicitly
            //overriding ToString method will display


            int age = 23;
            Console.WriteLine("Age: " + age);

            Console.ReadLine();
        }
    }
}
