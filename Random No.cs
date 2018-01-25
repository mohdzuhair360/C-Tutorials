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

            //Random number
            Random ranNum = new Random();
            Console.WriteLine("Random no between 1 - 100 = " + (ranNum.Next(1, 101)));
        }
    }

}
