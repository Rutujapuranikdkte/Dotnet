using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //converting number to others 
            int num = 10;
            Console.WriteLine("value : "+num);
            Console.WriteLine("value : "+ Convert.ToString(num));
            Console.WriteLine("value : " + Convert.ToDouble(num));

            //converting string to others 
            string name = "345";
            Console.WriteLine("value : " + Convert.ToInt32(name));
            Console.WriteLine("value : " + Convert.ToDouble(name));

            //converting bool to others 
            bool isVoted = true;
            Console.WriteLine("value : " + Convert.ToInt32(isVoted));
            Console.WriteLine("value : " + Convert.ToDouble(isVoted));
            Console.WriteLine("value : "+ Convert.ToString(isVoted));

            //converting Double to others
            double num2 = 345.789D;
            Console.WriteLine("value : " + Convert.ToInt32(num2));
            Console.WriteLine("value : " + Convert.ToString(num2));
        }
    }
}
