using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        int maxL = 0;

        foreach (var word in words)
        {
            if (word.Length > maxL)
            {
                maxL = word.Length;
            }
        }

        var builder = new StringBuilder();

        for (int i = 0; i < maxL; i++)
        {
            foreach (var word in words)
            {
                if (i < word.Length)
                {
                    builder.Append(word[word.Length - 1 - i]);
                }
            }
        }

        for (int i = 0; i < builder.Length; i++)
        {
            char currentLetter = builder[i];
            builder[i] = ']';
            int steps = 0;
            if (currentLetter >= 'A' && currentLetter <= 'Z')
            {
                steps = currentLetter - 'A' + 1;
            }
            else
            {
                steps = currentLetter - 'a' + 1;
            }

            int currentIndex = (i + steps) % builder.Length;
            if (currentIndex < i)
            {
                currentIndex--;
            }
            builder.Insert(currentIndex + 1, currentLetter);
            builder.Replace("]", "");
        }

        Console.WriteLine(builder);
    }
}
