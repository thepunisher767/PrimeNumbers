using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public class PrimeCheck
    {
        public static int GetPrime(int userInput)
        {
            List<int> primeList = new List<int>();
            int n = 0;
            bool isPrime = false;
            //Console.WriteLine($"Current list count: {primeList.Count}");
            while (primeList.Count <= userInput)
            {
                n++;
                isPrime = IsPrime(n);
                if (isPrime)
                {
                    primeList.Add(n);
                }

            }
            return primeList[userInput];

        }
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
