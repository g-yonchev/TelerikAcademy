/*  Problem 8. Binary short

    Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/

namespace BinaryShort
{
    using System;
    class BinaryShort
    {
        static void Main()
        {
            Console.Write("Enter signed short: ");
            short input = short.Parse(Console.ReadLine());
            string result = "";
            if (input < 0)
                result = "1" + ToBin((short)(32768 + input)).PadLeft(15, '0');
            else
                result = ToBin(input).PadLeft(16, '0');
            Console.WriteLine(result);
        }
        static string ToBin(short input)
        {
            string result = "";
            while (input > 0)
            {
                result = (input % 2).ToString() + result;
                input = (short)(input / 2);
            }
            return result;
        }
    }
}