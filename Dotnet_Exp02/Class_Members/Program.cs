using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Members
{
    class MyClass
    {
        // Class members
        string color = "red";        // field
        int maxSpeed = 200;          // field
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car speed is "+maxSpeed +" with color "+color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m=new MyClass();
            m.fullThrottle();
        }
    }
}
