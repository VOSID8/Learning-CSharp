using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5]
            {
                2,3,4,5,6
            };
            int[] newNumbers = new int[6];

            List<int> listNumbers = new List<int>();

            listNumbers.Add(1);
            listNumbers.Add(2);
            listNumbers.Add(3);

            listNumbers.Clear();

            Console.ReadLine();
        }
    }
}
