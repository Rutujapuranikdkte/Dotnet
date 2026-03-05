using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing numbers from 1 to 10
            int i = 1,j=11;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //do while
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 20);
        }
    }
}
