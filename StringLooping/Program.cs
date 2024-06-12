using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StringLooping
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string message = "C# is awesome!";

            //char[]
            Console.WriteLine(message[0]); // C
            Console.WriteLine(message[1]); // #
            Console.WriteLine(message[2]); // space

            for(int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(100);
            }

            Console.WriteLine(message.Contains("C#")); // True


            bool contains = false;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'C' && message[i + 1] == '#')
                {
                    contains = true;
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
