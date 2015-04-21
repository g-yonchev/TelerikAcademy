/*  Problem 3. Correct brackets

    Write a program to check if in a given expression the brackets are put correctly.
    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/

namespace CorrectBrackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class CorrectBrackets
    {
        static void Main()
        {
            Console.Write("Enter an expression: ");
            string input = Console.ReadLine();
            char[] brackets = input.Where(x => x == '(' || x == ')').ToArray();

            CheckBracketsAreCorrect(brackets);
        }

        private static void CheckBracketsAreCorrect(char[] brackets)
        {
            int countBrackets = 0;

            foreach (char symbol in brackets)
            {
                if (symbol == '(')
                {
                    countBrackets++;
                }
                else
                {
                    countBrackets--;
                }

                if (countBrackets < 0)
                {
                    break;
                }
            }

            if (countBrackets == 0)
            {
                Console.WriteLine("Correct.");
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
        }
    }
}
