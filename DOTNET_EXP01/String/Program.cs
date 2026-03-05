using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vaishnavi";

            //length of string is :
            Console.WriteLine("length of" + name + " is : " + name.Length);

            //converting into uppercase 
            Console.WriteLine("upper case : " + name.ToUpper());

            //converting into lowercase 
            Console.WriteLine("lower case : " + name.ToLower());

            //String concatenation :- it will uses + operator
            string last_name = "shintre";
            string full_name = name + last_name;
            Console.WriteLine("Full name is : " + full_name);

            Console.WriteLine("Full name by using concat methode : "+string.Concat(name,last_name));

            //String interpolation :- merging two string by using $ symbol
            Console.WriteLine($"The first name is {name} and last name is {last_name}");

            //for accessing the string use indexing (starts from 0) and it will not support reverse indexing
            char first = name[0];
            char last_name_lastletter = last_name[last_name.Length - 1];

            //i.e syntax = string_name[index]
            Console.WriteLine("output of string accessing : " + first + last_name_lastletter);

            Console.WriteLine("index of i in vaishnavi is : " + name.IndexOf("i"));

            //It will gives the substring from the index we are providing :
            Console.WriteLine("Substring from i in the shintre : " + last_name.Substring(last_name.IndexOf("i")));

            //
            string str = "It\'s alright.",str1 = "shut up \"vaishnavi\"",str2 = "\\ it is backslash";
            Console.WriteLine(str+str1+str2);
        }
    }
}
