using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Car
    {
        public string model;
        public string color;
        public double price;
        public Car(string modelName, string model_color, double model_price)
        {
            model = modelName; 
            color = model_color;
            price = model_price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 200000);
            Console.WriteLine(Ford.color + " " + Ford.price + " " + Ford.model);
        }
    }
}
