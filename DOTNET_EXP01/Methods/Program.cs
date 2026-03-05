using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        //parameterless methods
        static void Hello()
        {
            Console.WriteLine("hello world");
        }

        //parameters method
        static void Sum(int a,int b)
        {
            Console.WriteLine($"Sum is {a + b}");
        }

        //default parameter
        static void display(string name = "samruddhi")
        {
            Console.WriteLine($"name is {name}");
        }

        //return values
        static int sub(int a,int b)
        {
            return a - b;
        }

        //named arguments : it means here we are deciding the order
        static void displayNames(string child1,string child2,string child3)
        {
            Console.WriteLine($"child1 : {child1} child2 : {child2} child3 : {child3}");
        }
        static void Main(string[] args)
        {
            Hello();
            Sum(10, 20);
            display("vaishnavi"); //vaishnavi
            display(); //samruddhi

            int res = sub(78, 90);
            Console.WriteLine("substraction is : " + res);

            displayNames(child2: "samruddhi", child1: "vaishnavi", child3: "mrudula");
        }
    }
}
