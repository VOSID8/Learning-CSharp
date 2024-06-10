using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            string count = Console.ReadLine();

            int j = 0;
            while (j < int.Parse(count))
            {
                Console.WriteLine("YOOO");
                j++;
            }

            //condition ? true : false
            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k % 2 == 0 ? "Even" : "Odd");
                k++;
            }  


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(); 
            
            
        }
    }
}
