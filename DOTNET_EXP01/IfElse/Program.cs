using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter two numbers : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if(num1>0 && num2 > 0)
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("first Number is even");
                }
                else if(num2 % 2 == 0) 
                {
                    Console.WriteLine("second Number is even");
                }
            }
            else
            {
                Console.WriteLine("Number is negative");
            }

            //short hand if else
            string result = (num1 % 2 == 0 && num2 % 2 == 0) ? "Both numbers are even" : "any one or both numbers are negative";
            Console.WriteLine(result);
        }
    }
}
