using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Relevance_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int number = int.Parse(Console.ReadLine());

            string[] paragraphs = new string[number];

            int[] counting = new int[number];

            for (int i = 0; i < number; i++)
            {
                paragraphs[i] = Console.ReadLine();

                while (true)
                {
                    int startingIndex = 0;
                    int index = paragraphs[i].IndexOf(word, startingIndex);

                    if (index != -1)
                    {
                        counting[i]++;
                    }

                    startingIndex = index + word.Length;
                }
            }

            for (int i = 0; i < number; i++)
            {
                counting[i] == number;
            }
            
        }
    }
}
