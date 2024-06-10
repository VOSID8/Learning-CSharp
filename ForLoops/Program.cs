using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.Write("How many times do you want to loop? ");
            int loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                Console.WriteLine("HII");
            }

            Console.WriteLine("HERE");

            for(int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();


        }
    }
}
