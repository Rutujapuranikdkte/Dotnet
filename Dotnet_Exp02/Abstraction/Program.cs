using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Car
    {
        public abstract void cartype();
        public void speed()
        {
            Console.WriteLine("Speed is:100");
        }
    }
    class Vehicle : Car
    {
        public override void cartype()
        {
            Console.WriteLine("Car name is:Celerio");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.cartype();
            vehicle.speed();
        }
    }
}
