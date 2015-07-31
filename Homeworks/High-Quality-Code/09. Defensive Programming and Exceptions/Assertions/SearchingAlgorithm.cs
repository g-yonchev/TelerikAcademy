namespace Assertions
{
    using System;
    using System.Diagnostics;

    public class SearchingAlgorithm
    {
        public static int BinarySearch<T>(T[] collection, T value) where T : IComparable<T>
        {
            Debug.Assert(collection != null, "Input collection cannot be null.");
            Debug.Assert(collection.Length > 0, "Input collection cannot be empty.");
            Debug.Assert(value != null, "Value cannot be null.");

            return BinarySearch(collection, value, 0, collection.Length - 1);
        }

        private static int BinarySearch<T>(T[] collection, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            // I know, I check twise for null or empty collection and for null value :)
            Debug.Assert(collection != null, "Input collection cannot be null.");
            Debug.Assert(collection.Length > 0, "Input collection cannot be empty.");
            Debug.Assert(value != null, "Value cannot be null.");

            Debug.Assert(startIndex >= 0, "Start index cannot be negative.");
            Debug.Assert(endIndex >= 0, "End index cannot be negative.");
            Debug.Assert(endIndex <= collection.Length - 1, "End index is outside the range of the array.");
            Debug.Assert(endIndex >= startIndex, "End index should be bigger than start index.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (collection[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (collection[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
