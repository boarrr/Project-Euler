/*
 *The sum of the squares of the first ten natural numbers is 385
 * The square of the sum of the first ten natural numbers is 3025
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 2640
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/

using System;

namespace Project_Euler
{
    public class Problem6
    {
        public int Num { get; init; }
        
        /*
         * If (n) is zero, return 0
         * Else, return (n) * (n) and recurse the function with (n - 1)
         */
        private static int SumSquare(int n)
        {
            return n == 0 ? 0 : n * n + SumSquare(n - 1);
        }

        /*
         * If (n) is zero, return 0
         * Else, return (n) + recursive of function with (n - 1)
         */
        private static int SquareSum(int n)
        {
            return n == 0 ? 0 : n + SquareSum(n - 1);
        }
        
        // Finally, return the result of Square * Square - Sum
        public int PrintAns()
        {
            return SquareSum(Num) * SquareSum(Num) - SumSquare(Num); // Answer: 25164160
        }
    }
}