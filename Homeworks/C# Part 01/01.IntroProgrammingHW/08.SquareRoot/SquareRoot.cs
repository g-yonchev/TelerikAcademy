using System;

class SquareRoot
{
    static void Main()
    {
        /*  Problem 8. Square Root

            Create a console application that calculates and prints the square root of the number 12345.
        */

        Console.Title = "Square root";

        double number = Math.Sqrt(12345);
        Console.WriteLine("The square root of the number 12345 is = {0}", number);
    }
}
