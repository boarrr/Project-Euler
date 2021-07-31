using System;

namespace Project_Euler
{
    public class Problem1 
    {
        public int Num { get; init; }
        private int Total { get; set; }
        
        public int SumMult()
        {
            Total = 0;
            for (var i = 0; i < Num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Total += i;
                }
            }
            return Total;
        }
    }

    internal static class Program
    {
        public static void Main()
        {
            var testCase = new Problem1 {Num = 1000};
            
            Console.WriteLine(testCase.SumMult());
        }
    }
}

