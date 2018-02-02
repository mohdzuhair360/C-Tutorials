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
            this.person = "No person";
            this.name = "No Name";
            this.sigil = "No sigil";
            this.height = 0;
            this.weight = 0;
            NumOfHouses++;
        }

        //constructor to assign specific attributes to be passed
        //superclass house
        public House(string person, string name, string sigil, double height, double weight)
        {
            this.person = person;
            this.name = name;
            this.sigil = sigil;
            this.height = height;
            this.weight = weight;
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

        //method overloading
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }


        static void Main(string[] args)
        {
            House stark = new House("Arya", "stark", "wolf", 180, 60);
            Console.WriteLine("Class Constructors and Objects");
            Console.WriteLine("No of houses : " + House.getNumofHouses());
            Console.WriteLine(stark.toString());
            Console.WriteLine(stark.getSum(1.5, 4.78));
                 
            House Barotheon = new House
            {
                person = "Robert",
                name = "baretheon",
                sigil = "stag",
                height = 177,
                weight = 75

            };
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Inheritance");
            Lanister Cersei = new Lanister();

            Console.WriteLine(Cersei.toString());

            Cersei = new Lanister("Queen", "Cersei", "Lion", 190, 86, "Blonde");

            Console.WriteLine(Cersei.toString());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Polymorphism");

            Shape rect = new Rectangle(4.5, 5);
            Shape tri = new Triangle(4.4, 6);

            Console.WriteLine("Rect area : " + rect.area());
            Console.WriteLine("Tri area : " + tri.area());

            Rectangle combRect = new Rectangle(5, 5) + new Rectangle(6, 6);

            Console.WriteLine("CombRect : " + combRect.area());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Generic Data type");

            KeyValue<string, string> superman = new KeyValue<string, string>("", "");
            superman.key = "Superman";
            superman.value = "Clark Kent";

            KeyValue<int, string> samsung = new KeyValue<int, string>(0, "");
            samsung.key = 1234;
            samsung.value = "LED";

            Console.WriteLine();
            superman.showData();
            Console.WriteLine();
            samsung.showData();



        }
    }

    //subclass lanister inherit from house
    class Lanister : House
    {
        public string HairColor { get; set; }
        //new attributes

        public Lanister() : base()//called superclass
        {
            this.HairColor = "No Hair Colour";
            //add new default to superclass

        }
        //subclass new attributes constructor
        public Lanister (string person, string name, string sigil, double height, double weight, string HairColor) : base (person, name, sigil, height, weight)
        {
            this.HairColor = HairColor;

        }
        //override method with new one
        new public string toString()
        {
            return String.Format("{0} is from house {1} has sigil {2} and height is {3} and weight is {4} and has  hair colour {5}", person, name, sigil, height, weight, HairColor);
        }
    }

    //polymorphism
    //inherit one  abstract class per class
    
    abstract class Shape
    {
        public abstract double area();

        public void sayHi()
        {
            Console.WriteLine("Hello");
        }
    }

    public interface ShapeItem
    {
        double area();
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle (double num1, double num2)
        {
            length = num1;
            width = num2;
        }

        public override double area()
        {
            return length * width;
        }

        public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
        {
            double rectLength = rect1.length + rect2.length;
            double rectWidth = rect1.width + rect2.width;

            return new Rectangle(rectLength, rectWidth);
        }
    }

    class Triangle : Shape
    {
        private double theBase;
        private double width;

        public Triangle(double num1, double num2)
        {
            theBase = num1;
            width = num2;
        }

        public override double area()
        {
            return theBase * width;
        }
    }

    //generic class
    //unknown data type

    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }
        public void showData()
        {
            Console.WriteLine("{0} is {1} ", this.key, this.value);
        }

    }

}
