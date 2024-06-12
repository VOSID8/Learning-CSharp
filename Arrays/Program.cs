using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;

            int total = num1 + num2 + num3;

            int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            Console.WriteLine($"{num1} {num2} {num3}");
            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] numbers2 = new int[10];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers2[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }

            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for(int i = 0; i < angles.Length;i++)
            {
                Console.Write($"Enter angle {i}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach(int angle in angles)
            {
                angleSum += angle;
            }

            Console.WriteLine(angleSum == 100 ? "Valid" : "Invalid");

            int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };

            string test = "";
            test = test.Replace(" ", "");

            Array.Sort(numbers3);
            Array.Reverse(numbers3);
            //here you didn't need to reassign the array to itself

            foreach(int num in numbers3)
            {
                Console.Write($"{num} ");
            }

            foreach(int num in numbers3)
            {
                numbers[num] = default;
            }

            //Array.Clear(numbers3, 0, numbers3.Length);
            Array.Clear(numbers3, 0, 3);

            int position = Array.IndexOf(numbers3, 3);

            if(position != -1)
            {
                Console.WriteLine($"Found at position {position}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            int position2 = Array.IndexOf(numbers3, 3, 2, 4);

            Console.ReadLine();









            Console.ReadLine();

        }
    }
}
