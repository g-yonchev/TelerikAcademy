
namespace FirstLargerThanNeighbours
{
    using System;
    using System.Linq;
    class FirstLargerThanNeighbours
    {
        /*  Problem 6. First larger than neighbours

            Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
            Use the method from the previous exercise.
        */

        static void Main()
        {
            Console.Write("Enter integers of array, separated by space: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int index = LargerThanNeighbours(array);

            Console.WriteLine("Index: {0}", index);
        }

        static int LargerThanNeighbours(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i] > array[i + 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
