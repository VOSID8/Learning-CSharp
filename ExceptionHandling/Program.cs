using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;

                Console.Write("Enter a number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter a number between {0} and {1}", int.MinValue, int.MaxValue);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero exception");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid number");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
            } 

        }
    }
}
