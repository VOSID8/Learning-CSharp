using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

            int num = 7;
            int length = 5;

            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = num*i;
            }

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
