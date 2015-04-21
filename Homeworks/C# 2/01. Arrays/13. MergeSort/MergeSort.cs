namespace MergeSort
{
    using System;
    using System.Linq;
    class MergeSort
    {
        /*  Problem 13.* Merge sort

             Write a program that sorts an array of integers using the Merge sort algorithm.
        */

        static void Main()
        {
            Console.Write("Enter elements of an array separated by space and/or coma: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            MergeSortArray(array, 0, array.Length - 1);
            Console.WriteLine("Merge sorted array:");
            Console.WriteLine(String.Join(", ", array));
        }

        private static void MergeSortArray(int[] numbers, int left, int right)
        {
            int mid;

            if (left < right)
            {
                mid = (left + right) / 2;

                // Divide the array into two halves until we have an array
                // of one element, because a one-element array is considered
                // sorted
                MergeSortArray(numbers, left, mid);
                MergeSortArray(numbers, mid + 1, right);

                MergeArrays(numbers, left, mid + 1, right);
            }
        }

        private static void MergeArrays(int[] numbers, int left, int mid, int right)
        {
            int numbersCount = right - left + 1;
            int leftEnd = mid - 1;
            int position = left;
            int[] temp = new int[numbers.Length];

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                {
                    temp[position++] = numbers[left++];
                }
                else
                {
                    temp[position++] = numbers[mid++];
                }
            }

            while (left <= leftEnd)
            {
                temp[position++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[position++] = numbers[mid++];
            }

            for (int index = numbersCount - 1; index >= 0; index--)
            {
                numbers[right] = temp[right];
                --right;
            }
        }
    }
}