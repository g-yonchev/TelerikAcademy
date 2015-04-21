namespace HexadecimalToDecimal
{
    using System;
    class HexadecimalToDecimal
    {
        /*  Problem 4. Hexadecimal to decimal

            Write a program to convert hexadecimal numbers to their decimal representation.
        */

        static void Main()
        {
            Console.Write("Enter a hexadecimal number: ");
            string number = Console.ReadLine();

            ConvertHexadecimalToDecimal(number);
        }

        static void ConvertHexadecimalToDecimal(string number)
        {
            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {
                char hexDigit = number[i];
                int digit = (ConvertDigit(hexDigit));
                int pow = number.Length - 1 - i;

                result += digit * Power(pow);
            }

            Console.WriteLine(result);
        }

        static int Power(int pow)
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= 16;
            }
            return result;
        }

        static int ConvertDigit(char hexDigit)
        {
            int digit = 0;
            switch (hexDigit)
            {
                case '0': digit = 0; break;
                case '1': digit = 1; break;
                case '2': digit = 2; break;
                case '3': digit = 3; break;
                case '4': digit = 4; break;
                case '5': digit = 5; break;
                case '6': digit = 6; break;
                case '7': digit = 7; break;
                case '8': digit = 8; break;
                case '9': digit = 9; break;
                case 'A': digit = 10; break;
                case 'B': digit = 11; break;
                case 'C': digit = 12; break;
                case 'D': digit = 13; break;
                case 'E': digit = 14; break;
                case 'F': digit = 15; break;
                default: break;
            }
            return digit;
        }
    }
}
