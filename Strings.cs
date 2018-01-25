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
            
            //string
            string samp1 = "Winter is coming         ";
            string samp2 = "North remembers";
            Console.WriteLine("String 1 = " + (samp1));
            Console.WriteLine("String 2 = " + (samp2));

            //set how many space after writeline commands
            Console.Out.NewLine = "\n\n";


            //check for empty string, retun true or false
            Console.WriteLine("Empty or not? " + String.IsNullOrEmpty(samp1));
            Console.WriteLine("Empty or not? " + String.IsNullOrWhiteSpace(samp1));

            //search index of char in a string, return 10
            Console.WriteLine("Index of Coming " + samp1.IndexOf("coming"));

            //search word based on index
            //(1st no indicates index, 2nd no indicates end of index from 1st)
            Console.WriteLine("2nd word : " + samp1.Substring(7,2));

            //check equality
            //true for equal, false for different
            Console.WriteLine("Strings Equal " +samp1.Equals(samp2));

            //Check starts of string
            //return true or false
            Console.WriteLine("String 1 starts with Winter? : " + samp1.StartsWith("Winter"));

            //Check end of string
            //return true or false
            Console.WriteLine("String 2 ends with remembers? : " + samp2.EndsWith("remembers"));

            //trim spaces
            string samp3 = (samp1.Trim()+" "+samp2.Trim());
            Console.WriteLine("String 1 + String 2 : " + samp1 + samp2);
            Console.WriteLine("String 1 + String 2 after trimmed : " + samp3);

            //replace words in string
            //(words to be removed, words to be inserted)
            string samp4 = samp1.Replace("Winter", "White Walker");
            Console.WriteLine("Replacement of string 1 : " + samp4);

            //remove char in string
            //use index
            string samp5 = samp1.Remove(0,6);
            Console.WriteLine("Remove winter from string 1 : " + samp5);

            //string array
            string[] names = new string[3] { "Jon", "Ned", "Robb" };
            //join and print array
            Console.WriteLine("Name list  : " + String.Join(", ",names));

            //format string
            // 0,1,2,3 - 1st number is index of string
            //c = $
            //.00 round to 2 decimal place
            //, put coma after 100 place
            string format1 = String.Format("{0:c}{1:00.00}{2:#.00}{3:0,0}", 1.56, 223.2333, .767, 1000);
            Console.WriteLine("String format 1 : " + format1);


            //String Builder
            //Used to edit a string without use a new one

            StringBuilder sb1 = new StringBuilder();

            //append two string
            sb1.Append("Shape of You");
            sb1.AppendFormat(" - Ed Sheeran is {0} and from {1} ", "British", "Britain");
            Console.WriteLine(sb1);

            //replace
            sb1.Replace("a", "o");
            Console.WriteLine(sb1);

            //remove
            sb1.Remove(2, 3);
            Console.WriteLine(sb1);

        }
    }

}
