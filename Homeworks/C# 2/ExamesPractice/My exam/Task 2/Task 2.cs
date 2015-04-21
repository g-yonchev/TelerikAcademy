using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Task2
{
    static void Main()
    {
        long[] input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => long.Parse(x))
            .ToArray();


        long sumAbsoluteDif = 0;
        // !!!!!!!ako e even shte uvelichava i++; ako si e odd, nishto ne pravq
        for (long i = 1; i < input.Length; i++)
        {
            long currentIndex = i;
            long absoluteDif = 0;
            if (input[currentIndex] > input[i-1])
            {
                absoluteDif = input[currentIndex] - input[i - 1];
            }
            else
            {
                absoluteDif = input[i - 1] - input[currentIndex];
            }

            if (absoluteDif % 2 == 0)
            {
                sumAbsoluteDif += absoluteDif;
                i++;
            }
        }

        Console.WriteLine(sumAbsoluteDif);
    }
}
