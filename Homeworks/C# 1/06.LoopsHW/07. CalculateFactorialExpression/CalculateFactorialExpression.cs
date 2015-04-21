using System;
using System.Numerics;

class CalculateFactorialExpression
{
    static void Main()
    {
        /*  Problem 7. Calculate N! / (K! * (N-K)!)

            In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: .... For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
            Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
            Examples:

            n	k	    n! / (k! * (n-k)!)
            3	2	    3
            4	2	    6
            10	6	    210
            52	5	    2598960
        */

        Console.Title = "Calculate N! / (K! * (N-K)!)";

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter n: ");
        int k = int.Parse(Console.ReadLine());

        // n! / k!
        BigInteger factorialNdivX = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factorialNdivX *= (BigInteger)i;
        }

        // (n-k)!
        BigInteger factorialNsubX = 1;
        for (int i = 1; i <= n - k; i++)
        {
            factorialNsubX *= (BigInteger)i;
        }

        Console.WriteLine("The result of n! / (k! * (n-k)!):");
        Console.WriteLine(factorialNdivX / factorialNsubX);
    }
}