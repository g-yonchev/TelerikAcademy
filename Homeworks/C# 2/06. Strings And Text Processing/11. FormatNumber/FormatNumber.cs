/*  Problem 11. Format number

    Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
    Format the output aligned right in 15 symbols.
*/

namespace FormatNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            
            string hexNumber = number.ToString("X");

            string percentage = number.ToString("P2");

            string scientificNotation = number.ToString("G");

            Console.WriteLine(hexNumber);
            Console.WriteLine(percentage);
            Console.WriteLine(scientificNotation);
        }
    }
}

