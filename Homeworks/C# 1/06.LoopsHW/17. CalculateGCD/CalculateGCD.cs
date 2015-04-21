using System;

class CalculateGCD
{
    static void Main()
    {
        /*  Problem 17.* Calculate GCD

            Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
            Use the Euclidean algorithm (find it in Internet).
            Examples:

            a	    b	    GCD(a, b)
            3	    2	    1
            60	    40	    20
            5	    -15	    5
        */

        Console.Title = "Calculate GCD";

        Console.Write("Enter the first number: ");
        int bigger = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int lesser = int.Parse(Console.ReadLine());

        Console.Write("The greatest common divisor of {0} and {1} is: "
                        , bigger, lesser);
        if (bigger < lesser)
        {
            bigger = bigger + lesser;
            lesser = bigger - lesser;
            bigger = bigger - lesser;
        }
        int divisor = (bigger % lesser);
        while (divisor != 0)
        {
            bigger = lesser;
            lesser = divisor;
            divisor = bigger % lesser;
        }
        Console.WriteLine("{0}", lesser);
    }
}
