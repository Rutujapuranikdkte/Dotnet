using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeOverloading
{
    internal class Program
    {
        //int addition methode
        static int sumInt(int a,int b)
        {
            return a + b;
        }

        //double addition methode
        static double sumInt(double a,double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int res = sumInt(1, 2);
            double rs = sumInt(2.3, 4.5);
            Console.WriteLine($"integer sum : {res} double sum : {rs}");
        }
    }
}

