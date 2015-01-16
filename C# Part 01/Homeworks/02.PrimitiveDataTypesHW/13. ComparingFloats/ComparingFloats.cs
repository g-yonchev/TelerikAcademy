using System;

class ComparingFloats
{
    static void Main()
    {
        /*  Problem 13.* Comparing Floats

            Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
            Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

            Examples:

            Number a	    Number b	    Equal (with precision eps=0.000001)
            5.3	            6.01            false
            5.00000001	    5.00000003      true
            5.00000005	    5.00000001      true
            -0.0000007	    0.00000007      true
            -4.999999	    -4.999998       false
            4.999999	    4.999998        false
        */

        Console.Title = "Compare two folats";

        Console.Write("Enter first folating-point number (1.22): ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second folating-point number (1.22): ");
        double secondNumber = double.Parse(Console.ReadLine());
        double precision = 0.000001;
        bool isEqual;
        if (firstNumber >= secondNumber)
        {
            if (firstNumber - secondNumber < precision)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
        }
        else // firstNumber < secondNumber
        {
            if (secondNumber - firstNumber < precision)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
        }
        Console.WriteLine("Are they equals (with precision eps=0.000001): {0}", isEqual);
    }
}