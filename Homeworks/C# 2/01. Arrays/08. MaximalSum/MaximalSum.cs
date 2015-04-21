namespace MaximalSum
{
    using System;
    using System.Linq;
    class MaximalSum
    {
        /*  Problem 8. Maximal sum

            Write a program that finds the sequence of maximal sum in given array.
            Example:

            input	                                result
            2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4
            Can you do it with only one loop (with single scan through the elements of the array)?
        */

        static void Main()
        {
            //Console.Write("Enter elements of an array separated by space and/or coma: ");
            //int[] array = Console.ReadLine()
            //    .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(x => int.Parse(x))
            //    .ToArray();
            
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            Console.WriteLine("The array: " + string.Join(", ", array));

            int sequenceMaxSum = int.MinValue;
            int currentSum;
            int firstIndex = 0;
            int lastIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                currentSum = 0;
                currentSum += array[i - 1];

                // there can be one element with max value (sum). The sequence is will be with one element.
                if (currentSum > sequenceMaxSum)
                {
                    sequenceMaxSum = currentSum;
                }
                for (int j = 0; j < array.Length - i; j++)
                {
                    currentSum += array[i + j];

                    if (currentSum > sequenceMaxSum)
                    {
                        firstIndex = i - 1;
                        lastIndex = i + j;
                        sequenceMaxSum = currentSum;
                    }
                }
            }

            Console.WriteLine("Max sum is: {0}", sequenceMaxSum);

            Console.Write("Sub array: ");
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Console.Write(array[i]);
                if (i != lastIndex)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
