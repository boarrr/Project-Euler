/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

using System.Linq;
using System.Collections.Generic;

namespace Project_Euler
{
    public static class Problem4
    {
        
        /*
         * Start at a higher minimum for faster code execution
         * Iterate from the min to the max twice
         * Assign total to the sum of both numbers multiplied. IE: total = 900 x 900 = 810000
         * Typecast the total to a string, and then create a character array out of it
         * Reverse this, and create a new string out of it
         * If reversed is the same as the total as a string, add it to our list
         * Return the last result in the list, which will be the maximum number
         */
        public static int Palindrome()
        {
            const int min = 900; // Switch to higher number to make code execute faster
            const int max = 999;
            var list = new List<int>();
            
            for (var i = min; i < max; i++)
            {
                for (var j = min; j < max; j++)
                {
                    var total = i * j;
                    
                    var reversed = new string(total.ToString()
                        .ToCharArray()
                        .Reverse()
                        .ToArray());
                    
                    if (reversed == total.ToString()) list.Add(total);
                    
                }
            }

            return list.Max(); // Answer is 906609
        }
    }
}