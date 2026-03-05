using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAccessModifier
{
    class Fruit
    {
        public string fruit_name; //public means access that member anywhere 
        int value; // default it is private or we can also write private then it means we can access it only in that class not outside 
        protected bool isSold; //pprotected means we can access that only in that class and derived or inherited classes
        internal double price;  // internal means we can access it in the project not outside that project 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
