using System.Collections.Generic;

namespace cw8.Models
{
    public class PrimeNumbers
    {
        public static List<int> GeneratePrimeNumbers(int amount)
        {
            List<int> primeNumbers = new List<int>();
            int number = 2; // Start with the smallest prime number

            while (primeNumbers.Count < amount)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number);
                }
                number++;
            }

            return primeNumbers;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        
    }
}

