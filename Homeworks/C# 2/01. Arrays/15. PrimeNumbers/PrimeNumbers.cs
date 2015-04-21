namespace PrimeNumbers
{
    using System;
    class PrimeNumbers
    {
        /*  Problem 15. Prime numbers

            Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
        */

        static void Main()
        {
            int n = 10000000; 
            bool[] isPrime = new bool[n]; 

            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true; 
            }
            
            for (int j = 2; j < n; j++)
            {
                if (isPrime[j])
                {
                    for (int k = 2; (k * j) < n; k++)
                    {
                        isPrime[k * j] = false;
                    }
                }
            }
            
            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    Console.Write(i);
                }
                if (isPrime[i] && i < isPrime.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
