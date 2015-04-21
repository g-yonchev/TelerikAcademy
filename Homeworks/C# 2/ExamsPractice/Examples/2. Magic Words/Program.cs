using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Magic_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var words = new List<string>();

            for (int i = 0; i < number; i++)
            {
                words.Add(Console.ReadLine());
            }

            for (int i = 0; i < number; i++)
            {
                words.Insert((words[i].Length % (number + 1)), words[i]);

                if (i > (words[i].Length % (number + 1)))
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
            for (int i = 0; i < number; i++)
            {
                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in words)
                {
                    if (i <= word.Length - 1)
                    {
                        result.Append(word[i]);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
