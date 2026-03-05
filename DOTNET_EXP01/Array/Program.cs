using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deaclaration of array i.e datatype [] array_name ={values};
            //here once we declare the size then we can not change its size 
            int[] arr;
            int[] arr1 = {3,2,5,4,1};
            string[] str = new string[2];

            //traversal through array using for each loop
            foreach(int i in arr1)
            {
                Console.WriteLine(i);
            }

            //changing values by accessing the index 

            arr1[4] = 90;
            str[0] = "abc";

            //after adding values output :
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }

            //finding length
            Console.WriteLine("length : "+arr1.Length);

            //multiple methods on array :
            //1st : sort i.e sort the elements in the ascending order
            Array.Sort(arr1);

            //array after sorting 
            Console.WriteLine("Array after sorting in ascending order : ");
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }

            //to sort in descending order 1st sort in ascending then reverse to sort in descending order
            Array.Reverse(arr1);
            Console.WriteLine("Array after sorting in descending order : ");
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Highest value is : "+ arr1.Max()); //gives highest value
            Console.WriteLine("lowest value is : " + arr1.Min()); //gives minimum value
            Console.WriteLine("sum value is : " + arr1.Sum()); //gives sum of all elements in the array 

            //to declare the 2 dimensional array : datatype [ , ] arr_name = {values} 
            //to declare the 3 dimensional array : datatype [ , , ] arr_name = {values}
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //to iterate through the multidimensional array
            //GetLength(0) will gives us no.of rows and GetLength(1) will gives us no.of columns therefore by iterating it we will get the output
            
            for(int i = 0; i < arr3.GetLength(0); i++)
            {
                for(int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.WriteLine(arr3[i, j]);
                }
            }

            //accessing elements in multi dimensional array by using indexing are : arr_name[occurence of row element index , in that row col element index ]
            arr3[0, 1] = 90;

            //for each loop
            foreach(int i in arr3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
