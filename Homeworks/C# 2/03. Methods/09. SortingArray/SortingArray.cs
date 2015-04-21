namespace SortingArray
{
    using System;
    class SortingArray
    {
        /*  Problem 9. Sorting array

            Write a method that return the maximal element in a portion of array of integers starting at given index.
            Using it write another method that sorts an array in ascending / descending order.
        */

        static void Main()
        {
            int[] numbers = { 66, 90, 42, 11, 32, 44, 33, 61, 24, 42, 5, 7, 51, 3, 23, 84, 20, 22, 16, 73, 43, 33, 66, 39, 99,
                        88, 6, 51, 53, 25, 57, 95, 31, 61, 17, 81, 22, 61, 68, 52, 64, 32, 67, 38, 48, 58, 45, 62, 40, 19};

            SortDescending(numbers);

            PrintSortedArray(numbers);

            SortAscendingAndPrint(numbers);
        }

        private static void SortAscendingAndPrint(int[] numbers)
        {
            int[] newNums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                newNums[i] = numbers[numbers.Length - 1 - i];
            }

            PrintSortedArray(newNums);
        }

        private static void PrintSortedArray(int[] numbers)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                }
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }

        private static void SortDescending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int maxIndex = FindMaxIndex(numbers, i);
                int temp = numbers[i];
                numbers[i] = numbers[maxIndex];
                numbers[maxIndex] = temp;
            }
        }

        static int FindMaxIndex(int[] numbers, int startIndex)
        {
            int currentMax = int.MinValue;
            int currentMaxIndex = startIndex;

            for (int i = startIndex; i < numbers.Length; i++)
            {
                if (currentMax < numbers[i])
                {
                    currentMax = numbers[i];
                    currentMaxIndex = i;
                }
            }
            return currentMaxIndex;
        }
    }
}
