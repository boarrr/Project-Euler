/*
 * This file contains the main body of my Project Euler code, using Object-Orientated class/methods.
 */


using System;

namespace Project_Euler
{
    internal static class Program
    {
        public static void Main()
        {
            
            // Test case numbers for the problems go here
            var problem1 = new Problem1 {Num = 1000};
            var problem2 = new Problem2 {Nth = 4000000};
            var problem3 = new Problem3 {Num = 600851475143};
            var problem6 = new Problem6 {Num = 100};

            // Log the answers
            Console.WriteLine("Answer to Problem 1: {0}", problem1.SumMult());
            Console.WriteLine("Answer to Problem 2: {0}", problem2.Fibonacci());
            Console.WriteLine("Answer to Problem 3: {0}", problem3.PrimeFac());
            Console.WriteLine("Answer to Problem 4: {0}", Problem4.Palindrome());
            Console.WriteLine("Answer to Problem 5: {0}", Problem5.RemainderFunc());
            Console.WriteLine("Answer to Problem 6: {0}", problem6.PrintAns());
        }
    }
}

