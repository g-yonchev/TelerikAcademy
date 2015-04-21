using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Genome_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int N = numbers[0];
            int M = numbers[1];

            string inputGenome = Console.ReadLine();

            var decodedGenomes = new List<char>();

            string digit = string.Empty;
            char letter = 'A';
            int count = 0;

            foreach (var symbol in inputGenome)
            {

                if (char.IsDigit(symbol))
                {
                    digit += symbol;
                    continue;
                }

                if (digit == "")
                {
                    count = 1;
                }
                else
                {
                    count = int.Parse(digit);
                }

                if (char.IsLetter(symbol))
                {
                    letter = symbol;
                    digit = string.Empty;
                }

                for (int i = 0; i < count; i++)
                {
                    decodedGenomes.Add(letter);
                }
            }

            int lines = 0;

            lines += decodedGenomes.Count / N;
            if (decodedGenomes.Count % N != 0)
            {
                lines++;
            }

            int spaces = (Convert.ToString(lines)).Length;

            var currentLine = new StringBuilder();

            int currentSymbol = 0;

            for (int i = 1; i < lines + 1; i++)
            {
                string intervals = new string(' ', spaces - i.ToString().Length);
                currentLine.Append(intervals);
                currentLine.Append(i.ToString());
                currentLine.Append(" ");

                for (int j = 1; j <= N; j++)
                {
                    currentLine.Append(decodedGenomes[currentSymbol]);
                    currentSymbol++;
                    if (j % M == 0 && j != N)
                    {
                        currentLine.Append(" ");
                    }
                    if (currentSymbol > decodedGenomes.Count -1)
                    {
                        break;
                    }
                }

                Console.WriteLine(currentLine);
                currentLine.Clear();
            }

        }
    }
}
