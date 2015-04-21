using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string target = Console.ReadLine();

        int n = int.Parse(Console.ReadLine());

        string[] lines = new string[n + 1];

        for (int i = 0; i < n; i++)
        {
            int counter = 0;

            string[] line = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '(', ')', ';', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int j = 0; j < line.Length; j++)
			{
                if (line[j] == target)
                {
                    counter++;
                    line[j] = line[j].ToUpper();
                }
			}

            string currentLine = string.Join(" ", line);

            lines[counter] = currentLine;
        }


        for (int i = lines.Length - 1; i >= 1; i--)
        {
            Console.WriteLine(lines[i]);
        }
    }
}
