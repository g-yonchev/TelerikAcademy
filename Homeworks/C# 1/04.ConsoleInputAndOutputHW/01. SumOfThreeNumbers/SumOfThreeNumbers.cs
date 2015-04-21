using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        /*  Problem 1. Sum of 3 Numbers

            Write a program that reads 3 real numbers from the console and prints their sum.
            Examples:

            a	    b	    c	    sum
            3	    4	    11	    18
            -2	    0	    3	    1
            5.5	    4.5	    20.1	30.1
        */

        Console.Title = "Sum of 3 numbers";

        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of a + b + c = {0}", a+b+c);
    }
}