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
            //Addition
            Console.WriteLine("10 + 23 = " + (10 + 23));

            //Subtraction
            Console.WriteLine("10 - 23 = " + (10 - 23));

            //Multiplication
            Console.WriteLine("10 X 23 = " + (10 * 23));

            //Division
            Console.WriteLine("23/10 = " + (23 / 10));

            int i = 2;
            Console.WriteLine("i++ = " + (i++));
            //print i 1st then plus 1

            int j = 2;
            Console.WriteLine("++j = " + (++j));
            //j plus 1 then print

            int k = 2;
            Console.WriteLine("k-- = " + (k--));
            //print k 1st then minus 1

            int l = 2;
            Console.WriteLine("--l = " + (--l));
            //l minuss 1 then print

            int a = 2;
            Console.WriteLine("a +=3  = " + (a +=3));
            //a + 3

            int b = 2;
            Console.WriteLine("b -=3  = " + (b -= 3));
            //b - 3

            int c = 2;
            Console.WriteLine("c *=3  = " + (c *= 3));
            //c * 3

            int d = 2;
            Console.WriteLine("d /=3  = " + (d /= 3));
            //b / 3

            int e = 2;
            Console.WriteLine("e %=3  = " + (e %= 3));
            //c % 3

            //assigment test
            Console.WriteLine("i = " + (i));
            Console.WriteLine("i *=3  = " + (i *= 3));
            //i is equal to 3 after previous operation

        }
    }

}
