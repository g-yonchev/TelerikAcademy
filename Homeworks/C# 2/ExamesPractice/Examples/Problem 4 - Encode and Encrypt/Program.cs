using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();

            string cypher = Console.ReadLine();

            var builder = new StringBuilder();

            if (message.Length >= cypher.Length)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    int letterMsg = message[i] - 'A';
                    int lettercypher = cypher[i %cypher.Length] - 'A';
                    char ch = (char)((letterMsg ^ lettercypher) + 65);
                    builder.Append(ch);
                }
            }
            else
            {
                builder.Append(message);

                for (int i = 0; i < cypher.Length; i++)
                {
                    int letterMsg = builder[i % builder.Length] - 'A';
                    int lettercypher = cypher[i] - 'A';
                    char ch = (char)((letterMsg ^ lettercypher) + 65);

                    builder[i % builder.Length] = '?';
                    builder.Replace('?', ch);
                }
            }


            builder.Append(cypher);
            builder.Append(cypher.Length.ToString());

            var result = new StringBuilder();

            char currentLetter = builder[0];

            int count = 1;
            for (int i = 1; i < builder.Length; i++)
            {
                if (currentLetter == builder[i])
                {
                    count++;
                    currentLetter = builder[i];
                    continue;
                }
                else
                {
                    if (count > 2)
                    {
                        result.Append(count.ToString() + currentLetter);
                        currentLetter = builder[i];
                    }
                    else
                    {
                        result.Append(currentLetter, count);
                        currentLetter = builder[i];
                    }
                    count = 1;
                }
            }





            result.Append(cypher.Length.ToString());
            Console.WriteLine(result);

        }
    }
