using System;

class ExchangeIfGreater
{
    static void Main()
    {
        /*  Problem 1. Exchange If Greater

            Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
            Examples:

            a	    b	        result
            5	    2	        2       5
            3	    4	        3       4
            5.5	    4.5	        4.5     5.5
        */

        Console.Title = "Exchange If Greater";

        Console.Write("Enter first real number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("Greater number second: {0} {1}", secondNumber, firstNumber);
        }
        else
        {
            Console.WriteLine("Greater number second: {0} {1}", firstNumber, secondNumber);
        }


    }
}