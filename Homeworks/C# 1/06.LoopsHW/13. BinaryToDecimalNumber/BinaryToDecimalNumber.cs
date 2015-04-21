using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        /*  Problem 13. Binary to Decimal Number

            Using loops write a program that converts a binary integer number to its decimal form.
            The input is entered as string. The output should be a variable of type long.
            Do not use the built-in .NET functionality.
            Examples:

            binary	                        decimal
            0	                            0
            11	                            3
            1010101010101011	            43691
            1110000110000101100101000000	236476736
         */

        Console.Title = "Binary to Decimal Number";

        Console.Write("Enter a binary integer number (101000101): ");
        string number = Console.ReadLine();
        long numberInBinary = long.Parse(number);
        long sum = 0;
        long a = 0;
        for (int i = 0; i < number.Length; i++)
		{
            a = numberInBinary % 10;
            sum += a * (long)(Math.Pow(2, i));
            numberInBinary /= 10;
		}
        Console.WriteLine("The number in decimal is: {0}", sum);
    }
}