using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresAndAlgorithms
{
    class program
    {
        public static void Main(string[] args)
        {
           string firstString, secondString;
            //Gets the Words from the user
            Console.WriteLine("Enter FirstString");
            firstString= Console.ReadLine();
            Console.WriteLine("Enter SecondString");
            secondString = Console.ReadLine();
             AnagramWords anagram = new AnagramWords();
            //check if words are Anagram
            if (AnagramWords.areAnagram(firstString, secondString) == true)
            {
                Console.WriteLine("Both string are anagram string"); 
            }
            else
            {
                Console.WriteLine("Both string are not anagram string");
            }
            Console.ReadLine();


            // int[] arr = new int[6] { 5, 4, 10, 1, 6, 2 };
            //int i;
            //Console.WriteLine("\n Original Array Elements");

            //for (i = 0; i < 6; i++)
            //{
            //  Console.WriteLine(arr[i]);
            //}
            //InsersionSorting.insersionsort(arr, 6);
            // Console.WriteLine("The sorted Array is");
            //for (i = 0; i < 6; i++)
            //  Console.WriteLine(arr[i]);



        }
    }
}


