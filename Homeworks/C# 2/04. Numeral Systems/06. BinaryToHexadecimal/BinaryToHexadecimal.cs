namespace BinaryToHexadecimal
{
    using System;
    using System.Text;
    using System.Linq;

    class BinaryToHexadecimal
    {
        /*  Problem 6. binary to hexadecimal

            Write a program to convert binary numbers to hexadecimal numbers (directly).
        */

        static void Main()
        {
            Console.Write("Enter a number in binary: ");
            string number = Console.ReadLine();

            var builder = new StringBuilder();

            if (number.Length <= 4)
            {
                builder.Append('0', 4 - number.Length);
            }
            else
            {
                builder.Append('0', 4 - number.Length % 4);
            }

            builder.Append(number);

            string result = string.Empty;

            for (int i = 0; i/4 < builder.Length / 4; i += 4)
            {
                string binaryDigit = builder.ToString().Substring(i, 4);

                string digit = string.Empty;
                switch (binaryDigit)
                {
                    case "0000": digit = "0"; break;
                    case "0001": digit = "1"; break;
                    case "0010": digit = "2"; break;
                    case "0011": digit = "3"; break;
                    case "0100": digit = "4"; break;
                    case "0101": digit = "5"; break;
                    case "0110": digit = "6"; break;
                    case "0111": digit = "7"; break;
                    case "1000": digit = "8"; break;
                    case "1001": digit = "9"; break;
                    case "1010": digit = "A"; break;
                    case "1011": digit = "B"; break;
                    case "1100": digit = "C"; break;
                    case "1101": digit = "D"; break;
                    case "1110": digit = "E"; break;
                    case "1111": digit = "F"; break;
                    default: break;
                }

                result += digit;
            }

            Console.WriteLine(result);
        }
    }
}
