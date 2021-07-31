using System;

namespace Project_Euler
{
    internal static class Program
    {
        public static void Main()
        {
            
            // Test cases for the problems go here
            var problem1 = new Problem1 {Num = 1000};
            var problem2 = new Problem2 {Nth = 10};

            
            // Log our solutions
            Console.WriteLine("Answer to Problem 1: {0}", problem1.SumMult());
            Console.WriteLine(problem2.Nth);
        }
    }
}

