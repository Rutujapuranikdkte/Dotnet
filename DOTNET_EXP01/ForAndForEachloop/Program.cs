using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAndForEachloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print only even numbers in 1 to 10 using for loop;
            for(int i = 1; i <= 10; i++)
            {
                if(i%2 != 0)
                {
                    //here continue means it will continues the loop i.e to break the particular condition 
                    continue;
                }
                Console.WriteLine(i);
            }

            //print the odd numbers using the for each loop
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int i in arr)
            {
                if(i%3 == 0)
                {
                    //here break means it will directly moves the control to the out of any loop or switch statement also  
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("hello");
        }
    }
}
