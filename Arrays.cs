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
            //array
            //declare array
            int[] randNumArray;
            //declare size of array
            int[] randArray = new int[5];
            //declare elements of array
            int[] randArray2 = { 1, 2, 3, 4, 5 };

            //array length
            Console.WriteLine("Array Length : " + randArray2.Length);
            //element of array
            Console.WriteLine("Item 0 : " + randArray2[0]);

            //cycle index and its element
            for (int i = 0; i < randArray2.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, randArray2[i]);
            }

            //convert element of array to int
            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }

            //index for specific element
            Console.WriteLine("Index of '5' : " + Array.IndexOf(randArray2, 1));

            //string array
            string[] names = { "Jon", "Daenerys", "Robb" };

            //join array into string
            string joinNames = string.Join(", ", names);
            Console.WriteLine("Append names : " + joinNames);

            //split string into array
            string[] splitNames = joinNames.Split(',');
            for (int i = 0; i < splitNames.Length; i++)
            {
                Console.WriteLine("{0}:{1}", i, splitNames[i]);
            }
        }
    }

}
