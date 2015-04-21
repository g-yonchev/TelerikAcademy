/*  Problem 6. Sum integers

    You are given a sequence of positive integer values written into a string, separated by spaces.
    Write a function that reads these values from given string and calculates their sum.
    
    Example:
    input	                output
    "43 68 9 23 318"	    461
 */

namespace SumIntegers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class SumIntegers
    {
        static void Main()
        {
            Console.Write("Enter sequence of positive integers, separated by space: ");
            string input = Console.ReadLine();

            Console.WriteLine("Sum: " + CalculateSum(input));
        }

        static string CalculateSum(string input)
        {
            string[] numbers = input
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            long sum = 0;
            foreach (var number in numbers)
            {
                sum += long.Parse(number);
            }

            return sum.ToString();
        }
    }
}
