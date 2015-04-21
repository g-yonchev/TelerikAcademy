namespace BinaryToDecimal
{
    using System;
    class BinaryToDecimal
    {
        /*  Problem 2. Binary to decimal

            Write a program to convert binary numbers to their decimal representation.
        */

        static void Main()
        {
            Console.Write("Enter a binary number: ");
            string binaryNumber = Console.ReadLine();

            ConvertBinaryToDecimal(binaryNumber);
        }

        static void ConvertBinaryToDecimal(string number)
        {
            int digit = 0;
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                digit = (int)(number[i] - '0');
                int pow = number.Length - 1 - i;
                result += digit * Power(pow);
            }
            Console.WriteLine(result);
        }

        static int Power(int pow)
        {
            int number = 1;
            for (int i = 0; i < pow; i++)
            {
                number *= 2;
            }
            return number;
        }
    }
}
