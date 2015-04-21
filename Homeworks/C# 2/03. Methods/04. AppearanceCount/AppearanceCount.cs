namespace AppearanceCount
{
    using System;
    using System.Linq;
    class AppearanceCount
    {
        /*  Problem 4. Appearance count

            Write a method that counts how many times given number appears in given array.
            Write a test program to check if the method is workings correctly.
        */

        static void Main()
        {
            Console.Write("Enter integers of array, separated by space: ");
            int[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            CheckNumberExistInTheArray(array, number);
        }

        static void CheckNumberExistInTheArray(int[] array, int number)
        {
            if (Array.IndexOf(array, number) != -1)
            {
                CountNumberInArray(array, number);
            }
            else
            {
                Console.WriteLine("The number {0} doesn't exist in the array.", number);
            }
        }

        static void CountNumberInArray(int[] array, int number)
        {            
            int count = 0;
            foreach (var item in array)
            {
                if (item == number)
                {
                    count++;
                }
            }

            Console.WriteLine("The number {0} appears in the array: {1} time(s).", number, count);
        }
    }
}
