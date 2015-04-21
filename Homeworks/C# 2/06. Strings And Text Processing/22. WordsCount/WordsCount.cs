/*  Problem 22. Words count

    Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
*/

namespace WordsCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class WordsCount
    {
        static void Main()
        {
            Console.WriteLine("Enter some text:");
            string input = Console.ReadLine().ToUpper();
            string[] text = input.Split(new char[] { ' ', '.', ',', ':', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            var words = new Dictionary<string, int>();

            foreach (var word in text)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                }
                else
                {
                    words[word]++;
                }
            }

            if (words.Count == 0)
            {
                Console.WriteLine("you entered no words");
            }
            else
            {
                foreach (var word in words)
                {
                    Console.WriteLine("{0:D2} time(s): {1}", word.Value, word.Key);
                }
            }
        }
    }
}
