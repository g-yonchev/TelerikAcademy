/*  Problem 6. String length

    Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
*/

namespace StringLength
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StringLength
    {
        static void Main()
        {
            Console.WriteLine("Enter a text:");
            string input = Console.ReadLine();

            if (input.Length > 20)
            {
                input = string.Concat(input.Substring(0, 20), new string('*', input.Length - 20));                
            }

            Console.WriteLine(input);
        }
    }
}
