using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int n = int.Parse(Console.ReadLine());

        char[] chars = new char[n+1];

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();

            chars[int.Parse(line.Substring(1))] = line[0];
        }

        var builder = new StringBuilder();

        foreach (var number in numbers)
        {
            string binary = Convert.ToString(number, 2).PadLeft(8, '0');
            builder.Append(binary);
        }

        string[] ones = builder.ToString().Split(new char[] { '0' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        builder.Clear();
        foreach (var one in ones)
        {
            int currentCharPosition = one.Length;

            char ch = chars[currentCharPosition];
            builder.Append(ch);
        }

        Console.WriteLine(builder.ToString());
    }
}
