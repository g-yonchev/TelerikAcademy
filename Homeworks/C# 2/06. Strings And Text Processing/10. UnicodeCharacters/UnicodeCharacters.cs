/*  Problem 10. Unicode characters

    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.

    Example:
    input	    output
    Hi!	        \u0048\u0069\u0021
*/
namespace UnicodeCharacters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class UnicodeCharacters
    {
        static void Main()
        {
            Console.Write("Enter a text:");
            string text = Console.ReadLine();

            var result = new StringBuilder();

            foreach (var symbol in text)
            {
                result.Append(string.Format("{0}: ", symbol));
                result.Append(string.Format("\\u{0:X4}", (int)symbol));
                result.AppendLine();
            }
            Console.WriteLine(result.ToString());
        }
    }
}
