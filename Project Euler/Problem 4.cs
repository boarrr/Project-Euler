/*
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */

using System.Linq;
using System.Collections.Generic;

namespace Project_Euler
{
    public class Problem4
    {
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
                    
                    if (reversed == total.ToString())
                    {
                        list.Add(total);
                    }
                }
            }

            return list.Max(); // Answer is 906609
        }
    }
}