using System;

class Program
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine());
        long D = long.Parse(Console.ReadLine());

        long result = ((D * A) + (C * B)) / (B * D);
        long nominator = ((D * A) + (C * B));
        long denominator = (B * D);

        bool isCake = result >= 1;
        if (isCake) // Има цяло парче.
        {
            Console.WriteLine(result);
        }
        else // няма цяло парче.
        {
            decimal nominatorDecimal = Convert.ToDecimal(nominator);
            decimal denominatorDecimal = Convert.ToDecimal(denominator);
            decimal resultDecimal = nominatorDecimal / denominatorDecimal;
            Console.WriteLine("{0:F22}", resultDecimal);
        }
        Console.WriteLine("{0}/{1}", nominator, denominator);
    }
}