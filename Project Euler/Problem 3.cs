/*
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * What is the largest prime factor of the number 600851475143 ?
 */

namespace Project_Euler
{
    public class Problem3
    {
        public long Num { get; set; }

        /*
         * Start by eliminating all multiples of 2
         * Then starting at 3, iterate over all of the odd numbers, removing them if they aren't prime
         * Return the last number, which is the maximum prime.
         */
        public long PrimeFac()
        {
            while (Num % 2 == 0) Num /= Num;
            
            for (var i = 3; i < System.Math.Sqrt(Num); i += 2)
            {
                while (Num % i == 0) Num /= i;
                
            }

            return Num; // Answer = 6857
        }
    }
}