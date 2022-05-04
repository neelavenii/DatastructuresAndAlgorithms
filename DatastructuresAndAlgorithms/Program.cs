using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresAndAlgorithms
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[6] { 5, 4, 10, 1, 6, 2 };
            int i;
            Console.WriteLine("\n Original Array Elements");

            for (i = 0; i < 6; i++)
            {
                Console.WriteLine(arr[i]);
            }
           InsersionSorting.insersionsort(arr, 6);
            Console.WriteLine("The sorted Array is");
            for (i = 0; i < 6; i++)
                Console.WriteLine(arr[i]);
            Console.ReadLine();


        }
    }
}


