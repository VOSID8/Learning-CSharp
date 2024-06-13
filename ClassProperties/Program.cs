using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;

            public string Name
            {
                get { return name; }
                set { name = !string.IsNullOrEmpty(value) ? value : "No Name"; }
            }

            //public int Id { get; set; }
            //Name is a property that has a get and set accessor
            //The get accessor returns the value of the name field
            //The set accessor assigns a value to the name field
            //The value keyword is used to define the value being assigned to the name field
            //Name works as a field but it is a property used to access the field name
            
            public int Age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void SetName(string name)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : "No Name";
            }

            public void SetAge(int age)
            {
                this.age = !(age < 0) ? age : 0;
            }

            public string GetName()
            {
                   return name;
            }

            public int GetAge()
            {
                return age;
            }

            public string ReturnDetails()
            {
                return "Name: " + name + " Age: " + age;
            }
        }


        static void Main(string[] args)
        {
            Person person = new Person("Aba", 23);
            Console.WriteLine(person.ReturnDetails());

            person.Name = "Harry";
            person.Age = 25;

            Console.WriteLine(person.ReturnDetails());
            //The Name property is used to set the name field to Harry


            Console.ReadLine();

        }

        static void something(Person person)
        {
            x = 10;
            person.name
        }

    }
}
