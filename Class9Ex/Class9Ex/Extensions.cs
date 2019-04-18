using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class9Ex
{
    public static class Extensions
    {
        // Get the first letter from a string - Extension;
        public static char FirstLetter(this string first)
        {
            char f = first.FirstOrDefault();
            return f;
        }

        // Get the last letter from a string - Extension;
        public static char LastLetter(this string last)
        {
            char l = last.LastOrDefault();
            return l;
        }

        // Check if the number is even - Extension;
        public static bool isEven(this int evenNum)
        {
            if (evenNum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* Generic method that accepts an int and returns the first N 
        ( input ) items from that list - Extension */
        public static List<T> GetNfromList<T>(this List<T> list, int n)
        {
            return list.Take(n).ToList();
        }

    }
}
