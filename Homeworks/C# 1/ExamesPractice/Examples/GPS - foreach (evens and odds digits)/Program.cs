using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        N = Math.Abs(N);
        string M = Convert.ToString(N);
        Int64 sumEven = 0;
        Int64 sumOdd = 0;

        foreach (char digit in M)
        {
            string a = Convert.ToString(digit);
            Int64 b = Convert.ToInt64(a);
            if (b % 2 == 0)
            {
                sumEven += b;
            }
            else
            {
                sumOdd += b;
            }
        }

        if (sumOdd == sumEven)
        {
            Console.WriteLine("straight {0}", sumEven);
        }
        if (sumEven < sumOdd)
        {
            Console.WriteLine("left {0}", sumOdd);
        }
        if (sumOdd < sumEven)
        {
            Console.WriteLine("right {0}", sumEven);
        }
    }
}