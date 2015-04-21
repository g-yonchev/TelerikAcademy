namespace FillTheMatrix
{
    using System;
    class FillTheMatrix
    {
        /*  Problem 1. Fill the matrix

            Write a program that fills and prints a matrix of size (n, n) as shown below:
            Example for n=4:

            a)
            1	5	9	13
            2	6	10	14
            3	7	11	15
            4	8	12	16
        */

        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] array = new int[n, n];

            int startNumber = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[j, i] = startNumber;
                    startNumber++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                    if (j != n - 1)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
