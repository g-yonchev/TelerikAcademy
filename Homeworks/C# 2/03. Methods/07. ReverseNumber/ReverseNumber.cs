namespace ReverseNumber
{
    using System;
    using System.Text;
    using System.Linq;
    class ReverseNumber
    {
        /*  Problem 7. Reverse number

            Write a method that reverses the digits of given decimal number.

            Example:
            input	output
            256	    652
        */

        static void Main()
        {
            Console.Write("Enter a decimal number (123.45): ");
            char[] number = Console.ReadLine()
                .Select(x => Convert.ToChar(x))
                .ToArray();

            ReversDigits(number);

        }

        static void ReversDigits(char[] number)
        {
            int indexOfPoint = 0;
            var reversed = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(number[i]))
                {
                    reversed.Append(number[i]);
                }
                else
                {
                    indexOfPoint = i;
                }
            }

            reversed.Insert(indexOfPoint, '.');

            Console.WriteLine(reversed.ToString());
        }
    }
}
