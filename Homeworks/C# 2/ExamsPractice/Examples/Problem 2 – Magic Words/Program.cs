using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            int coutOfWords = int.Parse(Console.ReadLine());

            var words = new List<string>();

            for (int i = 0; i < coutOfWords; i++)
            {
                string line = Console.ReadLine();
                words.Add(line);
            }

            for (int i = 0; i < coutOfWords; i++)
            {
                string currentWord = words[i];
                int newIndex = currentWord.Length % (coutOfWords + 1);

                words[i] = null;
                words.Insert(newIndex, currentWord);

                words.Remove(null);
            }

            int maxLength = 0;

            for (int i = 0; i < coutOfWords; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                }
            }

            var result = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in words)
                {
                    if (i < word.Length)
                    {
                        result.Append(word[i]);                        
                    }
                }
            }

            Console.WriteLine(result);
        }
    }