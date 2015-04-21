namespace QuickSort
{
    using System;
    using System.Linq;
    class QuickSort
    {
        /*  Problem 14. Quick sort

            Write a program that sorts an array of strings using the Quick sort algorithm.
        */

        static void Main()
        {
            Console.Write("Enter elements of an array separated by space and/or coma: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            QuickSortArray(array, 0, array.Length - 1);
            Console.WriteLine("Quick sorted array:");
            Console.WriteLine(String.Join(", ", array));
        }

        public static void QuickSortArray(int[] array, int left, int right)
        {
            int i = left, j = right;
            int m = array[left / 2 + right / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(m) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(m) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    j--;
                    i++;
                }
            }

            if (left < j)
            {
                QuickSortArray(array, left, j);
            }

            if (i < right)
            {
                QuickSortArray(array, i, right);
            }
        }

    }
}
