using System;

class MatrixOfNumbers
{
    static void Main()
    {
        /*  Problem 9. Matrix of Numbers

            Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
            Examples:

            n = 2   matrix      n = 3   matrix      n = 4   matrix
                    1 2                 1 2 3               1 2 3 4
                    2 3                 2 3 4               2 3 4 5
                                        3 4 5               3 4 5 6
                                                            4 5 6 7
         */

        Console.Title = "Matrix of numbers";

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= number; i++)
        {
            for (int j = i; j < i + number; j++)
            {
                if (j <= 9)
                {
                    Console.Write(" {0} ", j);
                }
                else
                {
                    Console.Write("{0,-2} ", j);
                } 
            }
            Console.WriteLine();
        }
    }
}