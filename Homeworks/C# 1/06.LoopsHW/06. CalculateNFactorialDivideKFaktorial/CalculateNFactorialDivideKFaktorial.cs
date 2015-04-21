using System;
using System.Numerics;

class CalculateNFactorialDivideKFaktorial
{
    static void Main()
    {
        /*  Problem 6. Calculate N! / K!

            Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
            Use only one loop.
            Examples:

            n	k	n! / k!
            5	2	60
            6	5	6
            8	3	6720
        */

        Console.Title = "Calculate N! / K!";

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter n: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factorial *= (BigInteger)i;
        }
        // k < n
        // n! = nominator =   1 * 2 * 3 * ... * k-2 * k-1 * k * .... * n-2 * n-1 * n
        // k! = denominator = 1 * 2 * 3 * ... * k-2 * k-1 * k
        // sum = !(n-k)

        Console.WriteLine("The result of !n / !k :");
        Console.WriteLine(factorial);
    }
}