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
            int age = 19;
            
            //Relational Operators : >, <, >=, <=, !=, ==
            //Logical Operators : &&, ||, ^, !

            //if-else statements
            if((age >= 6) && (age <12))
            {
                Console.WriteLine("Primary School student");
            }
            else if ((age>=12) && (age<18))
            {
                Console.WriteLine("Secondary School student");

            }
            else if ((age>=18) && (age<54))
            {
                Console.WriteLine("Go to work!");
            }

            //check single statement
            bool canDrive = age > 17 ? true : false;
            int ageDrive = age > 17 ? age : 0;
            Console.WriteLine("Can drive or not? : " + (canDrive));
            Console.WriteLine("Age of driver : " + (ageDrive));

            //switch statements
            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 19:
                    Console.WriteLine("Get a job dude");
                    goto age19;
                    break;
                default:
                    Console.WriteLine("Out of range.");
                    break;
                  
            }
            //from goto
            age19:
            Console.WriteLine("Dont be lazy");
            return;

        }
    }

}
