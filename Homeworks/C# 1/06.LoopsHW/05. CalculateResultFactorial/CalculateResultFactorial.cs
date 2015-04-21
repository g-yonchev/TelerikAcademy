using System;

class CalculateResultFactorial
{
    static void Main()
    {
        /*  Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

            Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
            Use only one loop. Print the result with 5 digits after the decimal point.
            Examples:

            n	x	    S
            3	2	    2.75000
            4	3	    2.07407
            5	-4	    0.75781
        */

        Console.Title = "Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N";

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
       
        decimal result = 1.0M;
        decimal factorial = 1;
        int denominator = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= (decimal)i;
            denominator = (int)(Math.Pow(x, i));
            result += (decimal)(factorial) / (decimal)denominator;
        }
        Console.WriteLine("The result of 1 + 1!/x + 2!/x^2 + … + n!/x^n:");
        Console.WriteLine("{0:F5}", result);
    }
}