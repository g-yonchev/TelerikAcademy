namespace DecimalToBinary
{
    using System;
    class DecimalToBinary
    {
        /*  Problem 1. Decimal to binary

            Write a program to convert decimal numbers to their binary representation.
        */

        static void Main()
        {
            Console.Write("Enter a number in decimal: ");
            int number = int.Parse(Console.ReadLine());

            ConvertDecimalToBinary(number);
        }

        static void ConvertDecimalToBinary(int number)
        {
            int digit = 0;
            string result = string.Empty;

            while (number > 0)
            {
                digit = number % 2;
                number /= 2;
                result = digit + result;
            }

            Console.WriteLine(result);
        }
    }
}
