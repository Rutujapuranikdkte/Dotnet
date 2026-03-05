using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    //class is a logical entity and blueprint which contains the fields and the methods 
    class Fruit
    {
        //fields
        public string fruit_name;
        int quantity;

        //methods : here if we dont give access specifier then it is bydefault private 
        public void getFruits()
        {
            Console.WriteLine("Enter fruit name and its quantity");
            fruit_name = Console.ReadLine();
            quantity = Convert.ToInt32(Console.ReadLine());
        }

        //default parameter also called as optional parameter
        public void setFruits(string name = "mango" , int val = 10)
        {
            fruit_name = name;
            quantity = val;
        }
        public void display()
        {
            Console.WriteLine($"Fruit is {fruit_name} and quantity is : {quantity}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {   //creating the first object
            Fruit f = new Fruit();

            //creating the second object means we can create any number of objects
            Fruit f1 = new Fruit();

            //creating the third object means we can create any number of objects
            Fruit f2 = new Fruit();

            f.getFruits();
            //we can change the values here if that are public 
            f.fruit_name = "banana";
            f.display();

            f1.getFruits();
            f1.display();

            //here we can skip default parameters only in their sequence means 
            f2.setFruits(); //both are skip
            f2.setFruits("orange"); //only value is skiped means sequence matter
           // f2.setFruits(20); here we can not skip the 1st default parameter and then write 2nd because it will takes that value for the 1st parameter
        }
    }
}
