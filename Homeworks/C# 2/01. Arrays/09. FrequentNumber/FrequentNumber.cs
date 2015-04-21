namespace FrequentNumber
{
    using System;
    using System.Linq;

    class FrequentNumber
    {
        /*  Problem 9. Frequent number

            Write a program that finds the most frequent number in an array.
            Example:

            input	                                    result
            4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)
        */

        static void Main()
        {
            Console.Write("Enter elements of an array separated by space and/or coma: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            //int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            //Console.WriteLine("The array: " + string.Join(", ", array));

            int bestCount = 0;
            int bestElement = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentCount = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        ++currentCount;

                        if (currentCount >= bestCount)
                        {
                            bestCount = currentCount;
                            bestElement = array[i];
                        }
                    }
                }
            }

            Console.WriteLine("Element: " + bestElement);
            Console.WriteLine(bestCount + " time(s)");
        }
    }
}
