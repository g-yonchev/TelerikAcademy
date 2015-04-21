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

        int[] cheese = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int[] kneedles = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();


        for (int i = 0; i < kneedles.Length; i++)
        {
            int currentNumber = kneedles[i];

            int minIndex = 0;
            int maxIndex = cheese.Length - 1;
            int middleIndex;

            bool isFound = false;

            while (minIndex <= maxIndex)
            {
                middleIndex = minIndex / 2 + maxIndex / 2;

                while (middleIndex != 0)
                {
                    middleIndex--;
                }

                if (middleIndex > currentNumber)
                {
                    
                }
                
            }
        }

        Console.WriteLine();

    }
}

