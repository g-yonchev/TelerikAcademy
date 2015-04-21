using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Magic_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var words = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string currentWord = Console.ReadLine();

                words.Add(currentWord);
            }

            for (int i = 0; i < n; i++)
            {
                int newIndex = words[i].Length % (n + 1);

                words.Insert(newIndex, words[i]);

                if (i > newIndex)
                {
                    words.RemoveAt(i + 1);
                }
                else
                {
                    words.RemoveAt(i);
                }
            }

            var result = new StringBuilder();

            int maxLength = 0;

            for (int i = 0; i < n; i++)
            {
                if (maxLength < words[i].Length)
                {
                    maxLength = words[i].Length;
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                foreach (var letter in words)
                {
                    if (i <= letter.Length - 1) // 3
                    {
                        result.Append(letter[i]);
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
