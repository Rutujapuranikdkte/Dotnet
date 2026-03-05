using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //there are 5 datatypes
            //syntax to write variable : - type var_name = value;
            int num = 12;
            float point = 12.22F;
            double max = 123.456D;
            char division = 'A';
            string name = "samuddhi";
            bool getvisited = true;
            Console.WriteLine("num : "+num+"point : "+point+"max : "+ max+"division : "+ division+" name : "+name+ " getvisited :"+ getvisited);

            //here we can declare variables as : 
            int a, b;
            a = 10;
            b = 20;
            Console.WriteLine("A : "+a+" B"+ b);
        }
    }
}
