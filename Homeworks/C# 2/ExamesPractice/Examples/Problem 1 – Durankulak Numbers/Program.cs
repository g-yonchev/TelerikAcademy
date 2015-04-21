using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        var list = new List<string>();


        for (int i = 0; i < 26; i++)
        {
            char letter = 'A';
            char currentLetter = (char)(letter + (char)i);
            list.Add(currentLetter.ToString());
        }

        for (int i = 0; i < 26; i++)
        {
            char letter = 'a';
            list.Add((letter + list[i] ).ToString()); 
        }

        for (int i = 0; i < 26; i++)
        {
            char letter = 'b';
            list.Add((letter + list[i]).ToString());
        }
        for (int i = 0; i < 26; i++)
        {
            char letter = 'c';
            list.Add((letter + list[i]).ToString());
        }
        for (int i = 0; i < 26; i++)
        {
            char letter = 'd';
            list.Add((letter + list[i]).ToString());
        }
        for (int i = 0; i < 26; i++)
        {
            char letter = 'e';
            list.Add((letter + list[i]).ToString());
        }
        for (int i = 0; i < 26; i++)
        {
            char letter = 'f';
            list.Add((letter + list[i]).ToString());
        }

        string current = string.Empty;

        var arr = new List<long>();

        foreach (var ch in input)
        {
            current += ch;
            if (char.IsUpper(ch))
            {
                int index = list.IndexOf(current);
                arr.Add(index);
                current = "";
            }
        }

        long sum = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i] * (long)(Math.Pow(168, arr.Count - i - 1));
        }
        Console.WriteLine(sum);


    }
}
