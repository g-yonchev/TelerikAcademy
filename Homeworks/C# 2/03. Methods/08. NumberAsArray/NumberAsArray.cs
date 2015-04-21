namespace NumberAsArray
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    class NumberAsArray
    {
        private static object List;
        /*  Problem 8. Number as array

            Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
            Each of the numbers that will be added could have up to 10 000 digits.
        */

        static void Main()
        {
            Console.Write("Enter first positive integer number (max 10 000 digits): ");
            string firstNumber = Console.ReadLine();

            ArraysOfDigits(firstNumber);

            Console.Write("Enter second positive integer number (max 10 000 digits): ");
            string secondNumber = Console.ReadLine();

            ArraysOfDigits(secondNumber);

        }

        static void ArraysOfDigits(string number)
        {
            int[] array = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                array[i] = number[i] - '0';
            }

            Console.WriteLine("The array with digits: " + string.Join(", ", array));
        }
    }
}
