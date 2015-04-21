namespace MaximalKSum
{
    using System;
    class MaximalKSum
    {
        /*  Problem 6. Maximal K sum

            Write a program that reads two integer numbers N and K and an array of N elements from the console.
            Find in the array those K elements that have maximal sum.
        */

        static void Main()
        {
            int N = 10;
            int K = 2;

            int[] array = { 3, 2, 3, 4, 5, 3, 4, 3, 1, 0 }; // new int[N]

            Array.Sort(array);
            // 0, 1, 2, 3, 3, 3, 3, 4, 4, 5

            int[] kElements = new int[K];

            //              10 - 1 (9)             9 - 2 (7)
            for (int i = array.Length - 1; i >= array.Length - K; i--)
            {
                kElements[array.Length - i - 1] = array[i];
            }

            Array.Sort(kElements);
            // 4, 5

        }
    }
}
