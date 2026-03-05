using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ClassConstructor
{
    class Fruit
    {
        string fruit_name;
        int value;
        // it has two types of constructors as parameterless and parameterized
        //parameterless constructor

        //here if we give the access specifier as private then we can create an object only inside the same class
        public Fruit()
        {
            fruit_name = "none";
            value = 0;
        }
        //parameterized constructor
        public Fruit(string name,int val)
        {
            fruit_name = name;
            value = val;
        }

        public void display()
        {
            Console.WriteLine($"fruit name : {fruit_name} and value is : {value} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit f = new Fruit(); 
            f.display(); //fruit name : none and value is : 0

            Fruit f1 = new Fruit("mango",10);
            f1.display(); //fruit name : mango and value is : 10
        }
    }
}
