using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{   
    public enum Temperature
    {
        Freeze, //0
        Low, //1
        Warm, //2
        Boil //3
    }

    class Animal
    {
        static void Main(string[] args)
        {
            Temperature micTemp = Temperature.Low;
            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Freeze");
                    break;

                case Temperature.Low:
                    Console.WriteLine("Low");
                    break;

                case Temperature.Warm:
                    Console.WriteLine("Warm");
                    break;

                case Temperature.Boil:
                    Console.WriteLine("Boil");
                    break;
            }
        }
    }
    

    

}
