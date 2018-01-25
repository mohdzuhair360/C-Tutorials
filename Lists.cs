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
        }
    }

}
