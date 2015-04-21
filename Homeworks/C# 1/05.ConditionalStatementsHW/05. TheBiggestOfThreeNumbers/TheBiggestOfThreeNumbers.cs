using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        /*  Problem 5. The Biggest of 3 Numbers

            Write a program that finds the biggest of three numbers.
            Examples:

            a	    b	    c	    biggest
            5	    2	    2	    5
            -2	    -2	    1	    1
            -2	    4	    3	    4
            0	    -2.5	5	    5
            -0.1	-0.5	-1.1	-0.1
        */

        Console.Title = "The Biggest of 3 Numbers";

        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber >= secondNumber && firstNumber >=thirdNumber)
        {
            Console.WriteLine("The biggest number is: {0}", firstNumber);
        }
        else if (secondNumber >= thirdNumber)
        {
            Console.WriteLine("The biggest number is: {0}", secondNumber);
        }
        else
        {
            Console.WriteLine("The biggest number is: {0}", thirdNumber);
        }

    }
}