using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int W = int.Parse(Console.ReadLine());

        var list = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int j = 0; j < line.Length; j++)
            {
                list.Add(line[j]);
            }
        }

        int lettersOnLine = 0;

        int currentLetterLength = list[0].Length;

        for (int i = 1; i <= list.Count; i++)
        {
            if (currentLetterLength + list[i].Length <= W)
            {
                currentLetterLength += list[i].Length;
                continue;
            }
            lettersOnLine += list[i].Length;
            int lettersOnLine;
            list[i].Length <= W;
        }

    }
}
