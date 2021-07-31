
/*
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */


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

            return Total; // Answer is 233168
        }
    }
}

