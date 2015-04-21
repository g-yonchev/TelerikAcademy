namespace AllocateArray
{
    using System;
    class AllocateArray
    {
        /*  Problem 1. Allocate array

            Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
            Print the obtained array on the console.
        */

        static void Main()
        {
            Console.WriteLine("An array with 20 elements:");

            int numOfElements = 20;
            int[] array = new int[20];

            for (int i = 0; i < numOfElements; i++)
            {
                array[0] = i * 5;
                Console.WriteLine("Element {0, -2}: {1}", i + 1, array[0]);
            }
        }
    }
}
