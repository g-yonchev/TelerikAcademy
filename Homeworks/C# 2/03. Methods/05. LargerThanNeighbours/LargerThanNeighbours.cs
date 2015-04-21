namespace LargerThanNeighbours
{
    using System;
    using System.Linq;
    class LargerThanNeighbours
    {
        /*  Problem 5. Larger than neighbours

            Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
        */

        static void Main()
        {
            Console.Write("Enter integers of array, separated by space: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Enter an index: ");
            int number = int.Parse(Console.ReadLine());

            BiggerThanNeighbours(array, number);
        }

        static void BiggerThanNeighbours(int[] array, int number)
        {
            if (number - 1 < 0 || number + 1 > array.Length - 1)
            {
                Console.WriteLine("Does not have left or right neighbor!");
            }
            else
            {
                if ((array[number] > array[number - 1]) && (array[number] > array[number + 1]))
                {
                    Console.WriteLine("The number at index {0} is bigger than its neighbors", number);
                }
                else
                {
                    Console.WriteLine("The number at index {0} is not bigger than its neighbors", number);
                }
            }
        }
    }
}
