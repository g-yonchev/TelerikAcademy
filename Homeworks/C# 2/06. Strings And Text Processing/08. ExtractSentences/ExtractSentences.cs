/*  Problem 8. Extract sentences

    Write a program that extracts from a given text all sentences containing given word.

    Example:
    The word is: in

    The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

    The result: We are living in a yellow submarine. We will move out of it in 5 days.
*/

namespace ExtractSentences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class ExtractSentences
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string word = "in";

            string[] sentences = text
                .Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = new StringBuilder();

            foreach (var sentence in sentences)
            {
                string[] words = sentence
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                foreach (var singleWord in words)
                {
                    if (singleWord == word)
                    {
                        result.Append(sentence);
                        result.Append(". ");
                        break;
                    }
                }
            }

            Console.WriteLine(result);

        }
    }
}
