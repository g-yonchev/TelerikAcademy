namespace BinarySearch
{
    using System;
    class BinarySearch
    {
        /*  Problem 4. Binary search

            Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
        */

        static void Main()
        {
            int n = 10;
            int[] array = new int[10] { -3, 4, 22, 0, 18, 2, 35, 5, 10, 11 };

            int k = 20;

            Array.Sort(array);

            int result = -1;

            while (result < 0)
            {
                result = Array.BinarySearch(array, k);
                if (k == int.MinValue)
                {
                    break;
                }
                k--;
            }

            Console.WriteLine("Number is {0}", array[result]);
        }
    }
}

