using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moving_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] countWords = input.Split();
            int max = 0;

            for (int i = 0; i < countWords.Length; i++)
            {
                int current = countWords[i].Length;
                if (current > max)
                {
                    max = current;
                }
            }

            StringBuilder op = new StringBuilder();

            int index = 1;
            for (int jiji = 0; jiji < max; jiji++)
            {

                for (int i = 0; i < countWords.Length; i++)
                {
                    char[] letterByletter = countWords[i].ToCharArray();// char array

                    if (letterByletter.Length >= index)
                    {
                        op.Append(letterByletter[letterByletter.Length - index]);
                    }
                }
                index++;
            }

            // StringBuilder s = new StringBuilder(a);

            for (int i = 0; i < op.Length; i++)
            {
                int positionIndex;
                if (op[i] >= 'A' && op[i] <= 'Z')
                {
                    positionIndex = op[i] - 'A' + 1 + i;
                }
                else
                {
                    positionIndex = op[i] - 'a' + 1 + i;
                }
                
                if (positionIndex >= op.Length)
                {
                    positionIndex %= op.Length;
                }

                char needed = op[i];
                op.Remove(i, 1);
                op.Insert(positionIndex, needed);
            }
            Console.WriteLine(op);
        }
    }
}
