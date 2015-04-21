using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        n = Math.Abs(n);
        string m = Convert.ToString(n);
        long sumEven = 0;
        long sumOdd = 0;

        foreach (char digit in m)
        {
            string digitString = Convert.ToString(digit);
            long digitLong = long.Parse(digitString);
            if (digitLong % 2 == 0)
            {
                sumEven += digitLong;
            }
            if (digitLong % 2 == 1)
            {
                sumOdd += digitLong;
            }
        }

        if (sumEven == sumOdd)
        {
            Console.WriteLine("straight {0}", sumOdd);
        }
        if (sumEven > sumOdd)
        {
            Console.WriteLine("right {0}", sumEven);
        }
        if (sumEven < sumOdd)
        {
            Console.WriteLine("left {0}", sumOdd);
        }
    }
}