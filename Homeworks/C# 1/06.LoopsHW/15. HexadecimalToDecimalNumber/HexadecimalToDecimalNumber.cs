using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        /*  Problem 15. Hexadecimal to Decimal Number

            Using loops write a program that converts a hexadecimal integer number to its decimal form.
            The input is entered as string. The output should be a variable of type long.
            Do not use the built-in .NET functionality.
            Examples:

            hexadecimal	    decimal
            FE	            254
            1AE3	        6883
            4ED528CBB4	    338583669684
        */

        Console.Title = "Hexadecimal to Decimal Number";

        Console.Write("Enter a hexadecimal integer number (12A3D): ");
        string hex = Console.ReadLine();
        long number = 0;
        long power = 1;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int sign;
            switch (hex[i])
            {
                case 'A':
                case 'a': sign = 10;
                    break;
                case 'B':
                case 'b': sign = 11;
                    break;
                case 'C':
                case 'c': sign = 12;
                    break;
                case 'D':
                case 'd': sign = 13;
                    break;
                case 'E':
                case 'e': sign = 14;
                    break;
                case 'F':
                case 'f': sign = 15;
                    break;
                default: sign = hex[i] - 48;
                    break;
            }
            number += sign * power;
            power *= 16;
        }
        Console.WriteLine("The number in decimal is: {0}", number);
    }
}