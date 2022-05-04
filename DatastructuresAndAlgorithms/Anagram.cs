using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatastructuresAndAlgorithms
{
     class Anagram
    {
        //fuction to check wether two strings are anagram of each other
        public static bool areAnagram(string firstString, string secondString)
        {
           if (firstString.Length != secondString.Length)
            {
                return false;
            }
           //convert string to charector Array
           char[] firstCharsArray = firstString.ToLower().ToCharArray();
            char[] secondCharsArray = secondString.ToLower().ToCharArray();
            //sort Array
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharsArray);
            //check Each charector and position
            for (int i = 0; i < firstCharsArray.Length;i ++)
            {
                if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                {
                    return false;
                }
            }
            return true;

        }
    }
}
