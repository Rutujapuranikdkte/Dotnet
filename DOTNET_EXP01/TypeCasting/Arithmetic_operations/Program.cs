using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter values of 1st and 2nd number : ");
            //here console.ReadLine() will automatically returns the string means even if we give the integer input it will returns that in the string itself
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int sub = a - b;
            int mul = a * b;
            int div = a / b;
            int mod = a % b;
            Console.WriteLine("sum is : " + sum + "substraction is : " + sub + "multiplication is : " + mul + "Division : "+div+" Modulus : "+mod);
        }
    }
}
