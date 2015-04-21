using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        var indexes = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int startIndex = 0;
        int endIndex = 0;

        if (indexes[0] < indexes[1])
        {
            startIndex = indexes[0];
            endIndex = indexes[1];
        }
        else
        {
            startIndex = indexes[1];
            endIndex = indexes[0];
        }

        var inputNumbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToList();

        int[] subArray = new int[endIndex - startIndex + 1];

        for (int i = 0; i < subArray.Length; i++)
        {
            subArray[i] = inputNumbers[startIndex + i];

        }
        Array.Sort(subArray);

        var result = new List<int>();

        int count = 0;
        for (int i = 0; i < inputNumbers.Count; i++)
        {
            if (i < startIndex || i > endIndex)
            {
                result.Insert(i, inputNumbers[i]);
            }
            else
            {
                result.Insert(i, subArray[count]);
                count++;
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}
