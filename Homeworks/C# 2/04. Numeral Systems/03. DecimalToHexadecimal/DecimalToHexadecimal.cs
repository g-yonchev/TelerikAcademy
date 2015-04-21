namespace DecimalToHexadecimal
{
    using System;
    class DecimalToHexadecimal
    {
        /*  Problem 3. Decimal to hexadecimal

            Write a program to convert decimal numbers to their hexadecimal representation.
        */

        static void Main()
        {
            Console.Write("Enter a decimal number: ");
            int number = int.Parse(Console.ReadLine());

            ConvertDecimalToHexadecimal(number);
        }

        static void ConvertDecimalToHexadecimal(int number)
        {
            string result = string.Empty;

            while (number > 0)
            {
                int digit = number % 16;
                number /= 16;
                string HexDigit = ConvertDigit(digit);

                result = HexDigit + result;
            }

            Console.WriteLine(result);
        }

        static string ConvertDigit(int digit)
        {
            string hexDigit = string.Empty;

            switch (digit)
            {
                case 0: hexDigit = "0"; break;
                case 1: hexDigit = "1"; break;
                case 2: hexDigit = "2"; break;
                case 3: hexDigit = "3"; break;
                case 4: hexDigit = "4"; break;
                case 5: hexDigit = "5"; break;
                case 6: hexDigit = "6"; break;
                case 7: hexDigit = "7"; break;
                case 8: hexDigit = "8"; break;
                case 9: hexDigit = "9"; break;
                case 10: hexDigit = "A"; break;
                case 11: hexDigit = "B"; break;
                case 12: hexDigit = "C"; break;
                case 13: hexDigit = "D"; break;
                case 14: hexDigit = "E"; break;
                case 15: hexDigit = "F"; break;
                default: break;
            }
            return hexDigit;
        }
    }
}
