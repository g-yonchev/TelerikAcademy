using System;

class OddOrEven
{
    static void Main()
    {
        /*  Problem 1. Odd or Even Integers
            Write an expression that checks if given integer is odd or even.
            Examples:

            n	Odd?
            3	true
            2	false
            -2	false
            -1	true
            0	false
        */
        Console.Title = "Odd or even?";

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = ((number % 2) == 1);
        Console.WriteLine("Is the number odd? --> " + isOdd);
    }
}
