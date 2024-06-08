using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int aa, bb, cc;
            int aaa = 10, bbb = 20, ccc = 30;

            int x = 10;
            int y = 20;
            Console.WriteLine(x + y);

            long a = 1000000000000000000L;
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MaxValue);

            double negative = -123.456;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 123.456f;
            Console.WriteLine(precision);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            decimal money = 123.456m;

            Console.WriteLine(money);

            //string
            string name = "John Doe";
            Console.WriteLine(name);

            char letter = 'A';
            Console.WriteLine(letter);

            string textAge = "30";
            int age = Convert.ToInt32(textAge);

            string textBigNumber = "12345";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textPrice = "-123.45";
            double price = Convert.ToDouble(textPrice);
            Console.WriteLine(price);

            string textPrecision = "123.45";
            float precision2 = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision2);

            string textMoney = "123.45";
            decimal money2 = Convert.ToDecimal(textMoney);
            Console.WriteLine(money2);

            //boolean

            bool value = true;

            bool isMale = true;

            Console.WriteLine(isMale);

            Console.ReadLine();
        }
    }
}
