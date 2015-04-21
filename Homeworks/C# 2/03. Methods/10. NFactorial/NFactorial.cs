using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        /*  Problem 10. N Factorial

            Write a program to calculate n! for each n in the range [1..100].
        */

        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Factorial(i);
            }
        }

        static void Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = n; i > 0; i--)
			{
			    factorial = factorial * (BigInteger)i;
			}
            Console.WriteLine("{0, 2}! = {1}", n, factorial);
        }
    }
}
