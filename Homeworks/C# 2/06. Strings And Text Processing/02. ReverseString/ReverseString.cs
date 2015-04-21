/*  Problem 2. Reverse string

    Write a program that reads a string, reverses it and prints the result at the console.

    Example:
    input	    output
    sample	    elpmas
*/

namespace ReverseString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class ReverseString
    {
        static void Main()
        {
            Console.Write("Enter a string: ");

            //string input = "Az obi4am ma4 i boza";            
            string input = Console.ReadLine();

            string reversed = new string(input.Reverse().ToArray());
            Console.WriteLine("Reversed: " + reversed);
        }
    }
}
