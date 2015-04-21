using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Task1
{
    static void Main()
    {
        string inputOriginal = Console.ReadLine();

        string[] input = inputOriginal
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        string current = string.Empty;

        int allSum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            current = input[i];

            int currentSum = 0;


            int digit = 0;

            for (int j = 0; j < current.Length; j++)
            {
                digit = current[j] - 'a';

                currentSum += digit * Pow(current.Length - 1 - j);
            
            }

            allSum += currentSum;
        }

        string result = string.Empty;

        char[] arrLetters = new char[23];

        for (int i = 0; i < 23; i++)
        {
            arrLetters[i] = (char)('a' + i);
        }

        int resultSum = allSum;

        while (allSum > 0)
        {
            //  a i m, 0 8 neshto si
            int digit = allSum % 23;

            result = arrLetters[digit] + result;

            allSum /= 23;

        }

        Console.WriteLine("{0} = {1}", result, resultSum);

    }

    static int Pow(int p)
    {
        int pow = 1;
        for (int i = 0; i < p; i++)
        {
            pow *= 23;
        }
        return pow;
    }
}