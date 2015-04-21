/*  Problem 20. Palindromes

    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/

namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Palindromes
    {
        static void Main()
        {
            string text = "ABBA, lamal, exe, word, txt, pepsi";
            Console.WriteLine("Text: {0}\n\r", text);
            string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var result = new StringBuilder();

            bool isPalindrome;

            foreach (string word in words)
            {
                isPalindrome = WordIsPalindrom(word);
                if (isPalindrome)
                {
                    result.AppendLine(word);
                }
            }

            if (result.Length == 0)
            {
                Console.WriteLine("There is no palindroms!");
            }
            else
            {
                Console.WriteLine("Plaindromes:");
                Console.WriteLine(result);
            }
        }

        static bool WordIsPalindrom(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
