/*  Problem 17. Longest string

    Write a program to return the string with maximum length from an array of strings.
    Use LINQ.
*/

namespace LongestString
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] arrayWithStrings = new string[]
            {
                "long string",
                "some longer string",
                "this is the longest string"
            };

            var longest =
                (from str in arrayWithStrings
                 orderby str.Length descending
                 select str).First();

            Console.WriteLine(longest);
        }
    }
}
