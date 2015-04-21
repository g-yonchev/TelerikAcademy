/*  Problem 24. Order words

    Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/

namespace OrderWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("Enter words separated by space:");
            var words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x);

            Console.WriteLine("Ordered:");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
