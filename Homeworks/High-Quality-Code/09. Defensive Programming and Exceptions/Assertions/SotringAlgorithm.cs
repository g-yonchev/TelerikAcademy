namespace Assertions
{
    using System;
    using System.Diagnostics;

    public class SotringAlgorithm
    {
        public static void SelectionSort<T>(T[] collection) where T : IComparable<T>
        {
            Debug.Assert(collection != null, "Input collection cannot be null.");
            Debug.Assert(collection.Length > 0, "Input collection cannot be empty.");

            for (int index = 0; index < collection.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(collection, index, collection.Length - 1);
                Swap(ref collection[index], ref collection[minElementIndex]);
            }

            bool isCollectionSorted = CheckIfIsSorted(collection);
            Debug.Assert(isCollectionSorted, "Input collection is not sorted.");
        }

        private static bool CheckIfIsSorted<T>(T[] arr) where T : IComparable<T>
        {
            T lastNumber = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (lastNumber.CompareTo(arr[i]) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static int FindMinElementIndex<T>(T[] collection, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(collection != null, "Input collection cannot be null.");
            Debug.Assert(collection.Length > 0, "Input collection cannot be empty.");

            Debug.Assert(startIndex >= 0, "Start index cannot be negative.");
            Debug.Assert(endIndex >= 0, "End index cannot be negative.");
            Debug.Assert(endIndex <= collection.Length - 1, "End index is outside the range of the array.");
            Debug.Assert(endIndex >= startIndex, "End index should be bigger than start index.");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (collection[i].CompareTo(collection[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(minElementIndex >= 0 && minElementIndex <= collection.Length - 1, "Min element index is out of bounds.");

            return minElementIndex;
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            Debug.Assert(first != null, "First value cannot be null.");
            Debug.Assert(second != null, "Second value cannot be null.");

            T old = first;
            first = second;
            second = old;
        }
    }
}
