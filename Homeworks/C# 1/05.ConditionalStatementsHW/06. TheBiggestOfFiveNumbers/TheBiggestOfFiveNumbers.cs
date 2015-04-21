using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        /*  Problem 6. The Biggest of Five Numbers

            Write a program that finds the biggest of five numbers by using only five if statements.
            Examples:

            a	    b	    c	    d	    e	    biggest
            5	    2	    2	    4	    1	    5
            -2	    -22	    1	    0	    0	    1
            -2	    4	    3	    2	    0	    4
            0	    -2.5	0	    5	    5	    5
            -3	    -0.5	-1.1	-2	    -0.1	-0.1
        */

        Console.Title = "The Biggest of Five Numbers";

        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter d: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter e: ");
        int e = int.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b >= c && b >= d && b >= e)
        {
            Console.WriteLine(b);
        }
        else if (c >= d && c >= e)
        {
            Console.WriteLine(c);
        }
        else if (d >= e)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(e);
        }
    }
}