using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(a);
        }

        if (n == 2)
        {
            Console.WriteLine(b);
        }

        if (n == 3)
        {
            Console.WriteLine(c);
        }
        else
        {
            BigInteger result = 0;
            for (int i = 3; i < n; i++)
            {
                result = a + b + c;
                a = b;
                b = c;
                c = result;
            }

            Console.WriteLine(result);
        }
    }
}