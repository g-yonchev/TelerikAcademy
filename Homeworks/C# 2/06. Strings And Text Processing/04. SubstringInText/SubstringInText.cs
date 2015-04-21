/*  Problem 4. Sub-string in text

    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

    Example:
    The target sub-string is in

    The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

    The result is: 9
*/
namespace SubstringInText
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {

        static void Main()
        {
            Console.Write("Write a text: ");
            string text = Console.ReadLine();

            Console.Write("Enter a target sub-string: ");
            string target = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i <= text.Length - target.Length; i++)
            {
                string substring = text.Substring(i, target.Length);
                if (substring.ToUpper() == target.ToUpper())
                {
                    counter++;
                }
            }
            Console.WriteLine("Result: " + counter);
        }
    }
}
