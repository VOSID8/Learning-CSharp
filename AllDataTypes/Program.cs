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
            Console.WriteLine(long.MaxValue); //value: 9223372036854775807
            Console.WriteLine(long.MaxValue); //value: -9223372036854775808

            double negative = -123.456;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue); //value: 1.7976931348623157E+308
            Console.WriteLine(double.MinValue); //value: -1.7976931348623157E+308

            float precision = 123.456f;
            Console.WriteLine(precision);
            Console.WriteLine(float.MinValue); //value: -3.402823E+38
            Console.WriteLine(float.MaxValue); //value: 3.402823E+38

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
            Console.WriteLine(bigNumber); //value: 12345

            string textPrice = "-123.45";
            double price = Convert.ToDouble(textPrice);
            Console.WriteLine(price);  //value: -123.45

            string textPrecision = "123.4555555555";
            float precision2 = Convert.ToSingle(textPrecision);
            Console.WriteLine(precision2); //value: 123.4556

            string textMoney = "-123.45";
            decimal money2 = Convert.ToDecimal(textMoney);
            Console.WriteLine(money2); //value: -123.45

            //boolean

            bool value = true;

            bool isMale = true;

            Console.WriteLine(isMale);

            Console.ReadLine();
        }
    }
}
