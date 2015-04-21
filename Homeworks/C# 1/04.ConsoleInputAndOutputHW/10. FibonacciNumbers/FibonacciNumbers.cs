using System;

class FibonacciNumbers
{
    static void Main()
    {
        /*  Problem 10. Fibonacci Numbers

            Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
            Note: You may need to learn how to use loops.

            Examples:

            n	    comments
            1	    0
            3	    0 1 1
            10	    0 1 1 2 3 5 8 13 21 34
        */

        Console.Title = "Fibonachi numbers";

        Console.Write("Enter a number: ");
        ulong number = ulong.Parse(Console.ReadLine());

        ulong firstNumber = 0;
        ulong secondNumber = 1;
        ulong sum;

        for (ulong i = 0; i < number; i++)
        {
            Console.Write("{0} ", firstNumber);
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }
        Console.WriteLine();
    }
}