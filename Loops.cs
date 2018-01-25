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
            //loop
            int i = 0;

            //while
            while (i<10)
            {
                Console.WriteLine("i = " + (i));
                i++;
            }

            //do-while
            //guarantee go at least once before checking
            string guess;

            do
            {
                Console.WriteLine("Guess a number : ");
                guess = Console.ReadLine();
            } while (!guess.Equals ("15"));

            //for
            for (int j =0; j<10; j++)
            {
                Console.WriteLine("j = " + (j));
            }

            //for each
            //check each data in array/string
            string demons = "My demons hide";
            foreach(char Imagine in demons)
            {
                if (Imagine == 'h')
                {
                    Console.WriteLine("No of h in string is : " + (Imagine));
                }
                Console.WriteLine();
            }
        }
    }

}
