using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class House

    {
        //public - not protected
        //private - protected class, limited access to specific class

        //automatically set getters and setters
        public double height { get; set; }
        public double weight { get; set; }
        public string sigil { get; set; }
        public string person { get; set; }

        //manual getters and setters
        //value is default
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //default constructor
        public House()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sigil = "No sigil";
            this.person = "No person";
            NumOfHouses++;
        }

        //constructor to assign specific attributes to be passed
        public House(double height, double weight, string name, string sigil, string person)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.sigil = sigil;
            this.person = person;
            NumOfHouses++;

        }
        //static class define static members

        static int NumOfHouses = 0;
        
        public static int getNumofHouses()
        {
            return NumOfHouses;
        }

        public string toString()
        {
            return String.Format("{0} is from house {1} has sigil {2} and height is {3} and weight is {4}", person, name, sigil, height, weight);
        }

        static void Main(string[] args)
        {
            

        }
    }

}
