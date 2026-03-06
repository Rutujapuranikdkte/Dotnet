using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Car
    {
        public void color()
        {
            Console.WriteLine("Color of a car is red");
        }
    }
    class vehicle : Car
    {
        public void color()
        {
            Console.WriteLine("color of a vehicle is black");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicle v = new vehicle();
            v.color();
        }
    }
}
