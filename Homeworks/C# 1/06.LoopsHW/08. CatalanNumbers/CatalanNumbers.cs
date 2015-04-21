using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        /*  Problem 8. Catalan Numbers

            In combinatorics, the Catalan numbers are calculated by the following formula: Cn = ((2 * n)!) / (n+1)! * n!
            Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
            Examples:

            n	Catalan(n)
            0	1
            5	42
            10	16796
            15	9694845
        */

        Console.Title = "Catalan Numbers";

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        // 2*n!
        BigInteger a = n * 2;
        for (int i = 0; i < n * 2; i++)
        {
            a *= (BigInteger)(i+1);
        }

        // (n+1)!
        BigInteger b = n + 1;
        for (int i = 0; i < n + 1; i++)
        {
            b *= (BigInteger)(i+1);
        }

        // n!
        BigInteger c = n;
        for (int i = 0; i < n; i++)
        {
            c *= (BigInteger)(i+1);
        }

        BigInteger result = a / (b * c);

        Console.WriteLine("The result ot ((2 * n)!) / (n+1)! * n! :");
        Console.WriteLine(result);
    }
}