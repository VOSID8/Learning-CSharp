using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericAndTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double value = 10000 / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.#}",value));
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(string.Format("{0:0.000}", value));

            double money = -10D / 3D;
            Console.WriteLine(string.Format("-$10/$3 = ${0:0,00}", money));

            Console.WriteLine(money.ToString("C"));
            //"C" is a format specifier for currency
            //It will use the currency symbol of the current culture
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", new CultureInfo("en-US")));

            Console.ReadLine();

            string input = "100";

            //tryParse method
            int result; 
            if (int.TryParse(input, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
        }
    }
}
