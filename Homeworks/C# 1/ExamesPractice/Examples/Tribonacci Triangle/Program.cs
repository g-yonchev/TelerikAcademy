using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        BigInteger result = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write(a + " ");
                result = a + b + c;
                a = b;
                b = c;
                c = result;
                
            }
            Console.WriteLine();
        }
    }
}