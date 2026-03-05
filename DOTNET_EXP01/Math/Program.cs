using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //here we have math class which provides us basic aritmetic methods
            int num1,num2;
            double num3;
            Console.WriteLine("Enter Two number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());

            //for maximum number 
            Console.WriteLine("Highest number is : ");
            Console.WriteLine(System.Math.Max(num1, num2));

            //for minimum number 
            Console.WriteLine("Lowest number is : ");
            Console.WriteLine(System.Math.Min(num1, num2));

            //for sqrt of num1
            Console.WriteLine("Square root is : ");
            Console.WriteLine(System.Math.Sqrt(num1));

            //for abs of num2 means it will gives the positive number i.e absolute
            Console.WriteLine("Absolute is : ");
            Console.WriteLine(System.Math.Abs(num3));

            //for round of num2 i.e it will gives the round value means if num>=0.5 then takes next number otherwise takes previous number
            Console.WriteLine("round value of num2 is : ");
            Console.WriteLine(System.Math.Round(num3));
        }
    }
}
