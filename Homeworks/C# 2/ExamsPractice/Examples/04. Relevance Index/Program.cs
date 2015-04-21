using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Relevance_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int number = int.Parse(Console.ReadLine());

            string[][] jagged = new string[number][];

            int[] count = new int[number];

            for (int i = 0; i < number; i++)
            {
                string[] text = Console.ReadLine()
                    .Split(new char[] { ',', '.', '(', ')', ';', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                jagged[i] = new string[text.Length];

                for (int j = 0; j < text.Length; j++)
                {
                    if (text[j] == word)
                    {
                        jagged[i][j] = text[j].ToUpper();
                        count[i]++;
                    }
                    else
                    {
                        jagged[i][j] = text[j];
                    }

                }
            }

            int n = number + 1;

            for (int j = 0; j < number; j++)
            {
                int line = 0;
                int max = 0;

                for (int i = 0; i < number; i++)
                {
                    // && count[i] < n
                    if (max < count[i])
                    {
                        max = count[i];
                        line = i;
                    }
                }
                n = max;
                Console.WriteLine(string.Join(" ", jagged[line]));

                count[line] = -1;
            }
        }
    }
}
