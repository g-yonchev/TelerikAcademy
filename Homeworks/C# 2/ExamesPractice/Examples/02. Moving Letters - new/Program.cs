using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Moving_Letters___new
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] message = { "Fun", "exam", "right" };
            string[] message = Console.ReadLine()
                .Split(' ');

            int maxLength = 0;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Length > maxLength)
                {
                    maxLength = message[i].Length;
                }
            }

            var builder = new StringBuilder();
            for (int i = 0; i < maxLength; i++)
            {
                foreach (var word in message) // hi l = 2 
                {
                    if (word.Length > i)
                    {
                        builder.Append(word[word.Length - 1 - i]);
                    }
                }
            }


            // nmtuahFxgeir
            for (int i = 0; i < builder.Length; i++)
            {
                int positionIndex;
                if (builder[i] >= 'A' && builder[i] <= 'Z')
                {
                    positionIndex = builder[i] - 'A' + 1 + i;
                }
                else
                {
                    positionIndex = builder[i] - 'a' + 1 + i;
                }

                if (positionIndex >= builder.Length)
                {
                    positionIndex %= builder.Length;
                }

                char needed = builder[i];
                builder.Remove(i, 1);
                builder.Insert(positionIndex, needed);
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
