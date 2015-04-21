namespace MaximalSequence
{
    using System;
    using System.Linq;
    class MaximalSequence
    {
        /*  Problem 4. Maximal sequence

            Write a program that finds the maximal sequence of equal elements in an array.
            Example:

            input	                            result
            2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2
         */

        static void Main()
        {
            Console.Write("Enter an elements of array separated by a space: ");
            int[] array = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x))
                            .ToArray();
            // int[] array = { 2, 1, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            if (array.Length < 1)
            {
                return;
            }

            int currentElement = array[0];
            int currentSequence = 1;

            int maxSequence = 0;
            int bestElement = 0;

            int bestIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == currentElement)
                {
                    currentSequence++;
                }
                else
                {
                    currentElement = array[i];
                    currentSequence = 1;
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    bestElement = currentElement;
                    bestIndex = i - 1;
                }
            }

            int[] maxSequenceArray = new int[maxSequence];
            for (int i = 0; i < maxSequence; i++)
            {
                maxSequenceArray[i] = bestElement;
            }

            Console.WriteLine("Max sequence of equal elements: " + string.Join(", ", maxSequenceArray));
        }
    }
}
