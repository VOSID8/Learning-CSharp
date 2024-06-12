using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                {1, "John"},
                {2, "Steve"},
                {3, "Bill" }
            };

            names.Add(4, "Sam");
            names.Add(5, "Lucy");
            names.Add(6, "Test");

            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names.ElementAt(i).Key + " " + names.ElementAt(i).Value);
            }

            Dictionary<string,string> teachers = new Dictionary<string, string>
            {
                {"John", "Math"},
                {"Steve", "Science"},
                {"Bill", "English"}
            };

            if(teachers.TryGetValue("John", out string subject))
            {
                Console.WriteLine("John teaches " + subject);
            }
            else
            {
                Console.WriteLine("John is not a teacher");
            }

            if (teachers.ContainsKey("Steve"))
            {
                teachers.Remove("Steve");
            }
            else
            {
                Console.WriteLine("Steve is not a teacher");
            }

            Console.ReadLine();
        }
    }
}
