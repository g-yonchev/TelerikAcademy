namespace BinarySearch
{
    using System;
    using System.Linq;
    class BinarySearch
    {
        /*  Problem 11. Binary search

            Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
        */

        static void Main()
        {
            Console.Write("Enter elements of an array separated by space and/or coma: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Enter the target: ");
            int target = int.Parse(Console.ReadLine());

            
            //int[] array = { 2, 3, 4, 1, 22, -2, 33, -19, 0, 12 };
            //int target = -1;
            //Array.Sort(array);
            //// { -19, -2, 0, 1, 2, 3, 4, 12, 22, 33 };

            int minIndex = 0;
            int maxIndex = array.Length - 1;
            int middleIndex;

            bool isFound = false;

            while (minIndex <= maxIndex)
            {
                middleIndex = minIndex / 2 + maxIndex / 2;

                if (target < array[middleIndex])
                {
                    maxIndex = middleIndex - 1;
                }
                else if (target > array[middleIndex])
                {
                    minIndex = middleIndex + 1;
                }
                else // target == array[middleIndex]
                {
                    Console.WriteLine(middleIndex);
                    isFound = true;
                    break; // we found the target on index = middleIndex
                }
            }

            if (!isFound)
            {
                Console.WriteLine("The target {{0}} does not exist int the array.", target);
            }
        }
    }
}
