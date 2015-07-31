namespace Sorting
{
    using System;

    public class Sorting
    {
        public static int[] GenerateRandomArray()
        {
            Random randomGenerator = new Random();
            int[] array = new int[100];
            for (int count = 0; count < 100; count++)
            {
                array[count] = randomGenerator.Next(count, 1000000);
            }

            return array;
        }

        public static void Main()
        {
            SelectionSorting.SelectionSortArray();
            InsertionSorting.InsertionSortArray();
            QuickSorting.QuickSortArray();
        }
    }
}
