/*
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * What is the largest prime factor of the number 600851475143 ?
 */

namespace Project_Euler
{
    public class Problem3
    {
        public long Num { get; set; }

        public long PrimeFac()
        {
            int i;
            
            while (Num % 2 == 0)
            {
                Num /= Num;
            }
            
            for (i = 3; i < System.Math.Sqrt(Num); i += 2)
            {
                while (Num % i == 0)
                {
                    Num /= i;
                }
            }

            return Num; // Answer = 6857
        }
    }
}