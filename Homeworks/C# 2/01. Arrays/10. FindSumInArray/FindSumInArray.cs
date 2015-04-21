namespace FindSumInArray
{
    using System;
    using System.Linq;
    class FindSumInArray
    {
        /*  Problem 10. Find sum in array

            Write a program that finds in given array of integers a sequence of given sum S (if present).
            Example:

            array	                S	    result
            4, 3, 1, 4, 2, 5, 8	    11	    4, 2, 5
        */

        static void Main()
        {
            Console.Write("Enter elements of an array separated by space and/or coma: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Enter sum S: ");
            int S = int.Parse(Console.ReadLine());

            //int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            //Console.WriteLine("The array: " + string.Join(", ", array));

            //int S = 11;

            int currentSum;
            int firstIndex = 0;
            int lastIndex = 0;
            bool isFound = false;

            for (int i = 1; i < array.Length; i++)
            {
                if (isFound)
                {
                    break;
                }

                currentSum = 0;
                currentSum += array[i - 1];

                for (int j = 0; j < array.Length - i; j++)
                {
                    currentSum += array[i + j];

                    if (currentSum == S)
                    {
                        firstIndex = i - 1;
                        lastIndex = i + j;
                        isFound = true;
                        break;
                    }
                }
            }

            if (isFound)
            {
                Console.Write("Sequence with sum {0}: ", S);
                for (int i = firstIndex; i <= lastIndex; i++)
                {
                    Console.Write(array[i]);
                    if (i != lastIndex)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no sequence with sum {0}.", S);
            }

        }
    }
}
