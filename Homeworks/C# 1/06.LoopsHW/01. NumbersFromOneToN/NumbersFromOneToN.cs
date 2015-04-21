using System;

class NumbersFromOneToN
{
    static void Main()
    {
        /*  Problem 1. Numbers from 1 to N

            Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
            Examples:

            n	output
            3	1 2 3
            5	1 2 3 4 5
        */

        Console.Title = "Numbers from 1 to n";

        Console.Write("Please enter a number: ");
        uint number = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (i != number)
            {
                Console.Write("{0} ", i); // print " " (space) after every number exept the last one.   
            }
            else
            {
                Console.Write("{0}", i); // DO NOT print " " (space) after the last number. 
            }
        }
        Console.WriteLine();
    }
}