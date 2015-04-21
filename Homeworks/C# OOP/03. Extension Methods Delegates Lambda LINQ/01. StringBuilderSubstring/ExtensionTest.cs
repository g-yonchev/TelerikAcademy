/*  Problem 1. StringBuilder.Substring

    Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
*/

namespace StringBuilderSubstring
{
    using System;
    using System.Text;

    class ExtensionTest
    {
        static void Main()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Hello world");
            Console.WriteLine(strBuilder.ToString());

            StringBuilder newStrBuilder =  strBuilder.StringBuilderSubstring(6, 5);
            Console.WriteLine(newStrBuilder.ToString());

        }
    }
}
