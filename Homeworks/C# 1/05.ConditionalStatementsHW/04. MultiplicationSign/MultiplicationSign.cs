using System;

class MultiplicationSign
{
    static void Main()
    {
        /*  Problem 4. Multiplication Sign

            Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
            Use a sequence of if operators.
            Examples:

            a	    b	    c	    result
            5	    2	    2	    +
            -2	    -2	    1	    +
            -2	    4	    3	    -
            0	    -2.5	4	    0
            -1	    -0.5	-5.1	-
        */

        Console.Title = "Multiplication Sign";
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The sign of the product is: {0}", "0");
        }
        else if ((a < 0 && b > 0 && c > 0) ||   // a - negative
            (a > 0 && b < 0 && c > 0) ||        // b - negative
            (a > 0 && b > 0 && c < 0) ||        // c - negative
            (a < 0 && b < 0 && c < 0))          // a,b,c - negative
        {
            Console.WriteLine("The sign of the product is: {0}", "-");
        }
        else
        {
            Console.WriteLine("The sign of the product is: {0}", "+");
        }
    }
}