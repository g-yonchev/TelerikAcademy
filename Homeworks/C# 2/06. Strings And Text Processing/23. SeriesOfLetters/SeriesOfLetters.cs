/*  Problem 23. Series of letters

    Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
    Example:

    input	                    output
    aaaaabbbbbcdddeeeedssaa	    abcdedsa
*/

namespace SeriesOfLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class SeriesOfLetters
    {
        static void Main()
        {
            Console.Write("Enter a text:");
            string text = Console.ReadLine();

            var result = new StringBuilder();
            char previousLetter = text[0];

            result.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (previousLetter != text[i])
                {
                    result.Append(text[i]);
                }
                previousLetter = text[i];
            }

            Console.WriteLine("Replaced: " + result.ToString());
        }
    }
}
