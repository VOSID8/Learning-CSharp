using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {

        public string name;
        public int age;
        struct Person
        {
            public string name;
            public int age;
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }

        class Person2
        {
            public string name;
            public int age; 
            //you can also create a constructor without parameters
            //your wish

            public Person2()
            {
            }
            public Person2(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public Person2(string name)
            {
                this.name = name;
                this.age = -1;
            }

            public Person2(int age)
            {
                this.name = "No Name";
                this.age = age;
            }

        }

        //use class to create objects when you need to create multiple instances of the same type
        //but don't need to assign a value to the object's fields when you create it
        //when you create an object of a class, it is called an instance of the class

        
        static void Main(string[] args)
        {
            Person person1 = new Person("John", 25);
            Person2 person2 = new Person2();

            Console.WriteLine("Name: " + person1.name);
            Console.WriteLine("Age: " + person1.age);
        }
    }
}
