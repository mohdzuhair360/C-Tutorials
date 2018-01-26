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
            try
            {
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0} = {1}", num, (10 / num));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");
                //return type of error
                Console.WriteLine(ex.GetType().Name);
                //return the message of error
                Console.WriteLine(ex.Message);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

            }

        }
    }

}
