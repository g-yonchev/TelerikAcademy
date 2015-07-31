namespace Assertions
{
    using System;

    public class AssertionsHomework
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SotringAlgorithm.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            SotringAlgorithm.SelectionSort((int[])null); // Test sorting null array
            SotringAlgorithm.SelectionSort(new int[0]); // Test sorting empty array
            SotringAlgorithm.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, -1000));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 0));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 17));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 10));
            Console.WriteLine(SearchingAlgorithm.BinarySearch(arr, 1000));
        }
    }
}
