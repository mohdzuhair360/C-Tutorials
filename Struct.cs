using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate double GetSum(double num1, double num2);

namespace ConsoleApp2
{   
   //delegates
   

    class Animal
    {

        static void Main(string[] args)
        {
            //anonymous method
            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };
            Console.WriteLine("5 + 10 = "+ sum(5,10));

            //lambda
            Func<int, int, int> getSum = (x, y) => x + y;
            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));

            //lambda with list
            List<int> numList = new List<int> { 5, 10, 15, 20, 15 };
            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();

             foreach(int num in oddNums )
            {
                Console.WriteLine(num + ",");

            }
        }
    }
    

}
