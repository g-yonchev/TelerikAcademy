using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        BigInteger d = BigInteger.Parse(Console.ReadLine());
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        BigInteger result = 0;

        for (int rows = 0; rows < row; rows++)
        {
            for (int cols = 0; cols < col; cols++)
            {
                Console.Write(a + " ");
                result = a + b + c + d;
                a = b;
                b = c;
                c = d;
                d = result;
            }
            Console.WriteLine();
        }
    }
}