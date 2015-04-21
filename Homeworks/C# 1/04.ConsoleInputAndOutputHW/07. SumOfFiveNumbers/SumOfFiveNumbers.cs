using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        /*  Problem 7. Sum of 5 Numbers

            Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
            Examples:

            numbers	            sum
            1 2 3 4 5	        15
            10 10 10 10 10	    50
            1.5 3.14 8.2 -1 0   11.84
        
        */

        Console.Title = "Sum of 5 numbers";
        Console.WriteLine("Enter five numbers, separated by a space.");
        string[] numbers = Console.ReadLine().Split(' ');

        int a = int.Parse(numbers[0]);
        int b = int.Parse(numbers[1]);
        int c = int.Parse(numbers[2]);
        int d = int.Parse(numbers[3]);
        int e = int.Parse(numbers[4]);
        Console.WriteLine("The sum of the numbers is = {0:F2}", a+b+c+d+e);
        
    }
}
