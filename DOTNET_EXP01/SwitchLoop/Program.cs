using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the any number from 1 to 5 ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num){
                case 1:Console.WriteLine("1 number is pressed");
                    break;
                case 2: Console.WriteLine("2 number is pressed");
                    break;
                case 3: Console.WriteLine("3 number is pressed");
                    break;
                case 4: Console.WriteLine("4 number is pressed");
                    break;
                case 5: Console.WriteLine("5 number is pressed");
                    break;
                default: Console.WriteLine("no any number from 1 to 5 is pressed");
                    break;
            }
        }
    }
}
