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
            //lists
            //like arrays but list will keep resize automatically after add elements
            //declare list
            List<int> numList = new List<int>();

            //add element to list
            numList.Add(5);
            numList.Add(50);
            numList.Add(15);

            //add array to list
            int[] array1 = { 2, 4, 6, 8 };
            numList.AddRange(array1);

            //print list
            numList.ForEach(Console.WriteLine);
            /*for (int i = 0; i < numList.Capacity; i++)
            {
                Console.WriteLine(numList[i]);
            }*/

            //clear list - numList.Clear();
            Console.WriteLine();

            //declare array in list
            List<int> numlist2 = new List<int>(array1);
            numlist2.ForEach(Console.WriteLine);
            Console.WriteLine();

            //delare array in list #2
            List<int> numlist3 = new List<int>(new int[] { 1, 2, 3, 4, 5 });
            numlist3.ForEach(Console.WriteLine);
            Console.WriteLine();

            //insert element of list at specific index (index, new element)
            numList.Insert(0, 505);
            numList.ForEach(Console.WriteLine);
            Console.WriteLine();

            //remove element of list at specified index (index)
            //remove element from initial list
            numList.RemoveAt(2);
            numList.ForEach(Console.WriteLine);
            Console.WriteLine();

            //print out element in specified index
            Console.WriteLine("5 is on index : " +numlist3.IndexOf(0));
            Console.WriteLine();

            //check if list contain the element
            Console.WriteLine("1 in List or not? " + numlist3.Contains(1));
            Console.WriteLine();

            //list string

            List<string> strList1 = new List<string>(new string[] { "Jon", "Igrite", "Cersei" });

            //check for element in list
            //string comparer ordinal ignore case to ignore capital/small letter
            Console.WriteLine("Cersei is on index? : " + strList1.Contains("cersei", StringComparer.OrdinalIgnoreCase));
            Console.WriteLine();

            //sort list

            //alphabetically
            strList1.Sort();
            strList1.ForEach(Console.WriteLine);

            strList1.Sort();
            strList1.ForEach(Console.WriteLine);



        }
    }

}
