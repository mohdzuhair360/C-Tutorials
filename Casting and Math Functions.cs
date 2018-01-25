using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class tutorial1
    {
        static void Main(string[] args)
        {
            //casting happen automatically if no magnitude loss
            double pi = 3.14;
                int intPi = (int)pi;
            Console.WriteLine("pi = " + (pi));
            Console.WriteLine("intPi = " + (intPi));
            //pi prints 3.14, intPi prints 3

            //math function
            double num1 = 10.5;
            double num2 = 2;
            Console.WriteLine("number 1 = " + (num1));
            Console.WriteLine("number 2 = " + (num2));

            //Absolute num1
            Console.WriteLine("Math.Abs(num1) = " + (Math.Abs(num1)));

            //Ceiling num1 = round up to upper boundary
            Console.WriteLine("Math.Ceiling(num1) = " + (Math.Ceiling(num1)));

            //Floor num1 = round down to lower boundary
            Console.WriteLine("Math.Floor(num1) = " + (Math.Floor(num1)));

            //Max num1 v num2
            Console.WriteLine("Math.Max(num1 and num2) = " + (Math.Max(num1, num2)));

            //min num1 v num2
            Console.WriteLine("Math.min(num1 and num2) = " + (Math.Min(num1, num2)));

            //power
            Console.WriteLine("Math.Pow(num1 and num2) = " + (Math.Pow(num1, num2)));

            //round
            Console.WriteLine("Math.Round(num1) = " + (Math.Round(num1)));

            //Square root
            Console.WriteLine("Math.Sqrt(num1) = " + (Math.Sqrt(num1)));

        }
    }

}
