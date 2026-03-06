using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IFirstInterface
    {
        void myMeth1();
    }
    interface ISecondInterface
    {
        void myMeth2();
    }

    class Demo : IFirstInterface, ISecondInterface
    {
        public void myMeth1()
        {
            Console.WriteLine("Interface of method 1");
        }
        public void myMeth2()
        {
            Console.WriteLine("Interface of method 2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.myMeth1();
            demo.myMeth2();
        }
    }
}
