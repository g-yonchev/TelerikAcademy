namespace _SelectionSort
{
    using System;
    using System.Linq;
    class SelectionSort
    {
        /*  Problem 7. Selection sort

            Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
            Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
        */

        static void Main()
        {
            Console.Write("Enter elements of array, separated by space and/or coma: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            // int[] array = new int[] { 23, 25, -2, -33, 0, 3 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) 
                    {
                        int temporary = array[i];
                        array[i] = array[j];
                        array[j] = temporary;
                    }
                }
            }

            Console.WriteLine("The sorted array: " + string.Join(", ", array));
        }
    }
}
