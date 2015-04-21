namespace FillTheMatrix
{
    using System;
    class FillTheMatrix
    {
        /*  Problem 1. Fill the matrix

            Write a program that fills and prints a matrix of size (n, n) as shown below:
            Example for n=4:

            c)
            7	11	14	16
            4	8	12	15
            2	5	9	13
            1	3	6	10
        */
        static void Main()
        {
            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int rows = 0;
            int cols = 0;
            int value = 1;

            for (int i = n - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[rows++, cols++] = value++;
                }
            }

            for (int j = 1; j < n; j++)
            {
                rows = j;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[cols++, rows++] = value++;
                }
            }

            for (rows = 0; rows < n; rows++)
            {
                for (cols = 0; cols < n; cols++)
                {
                    Console.Write("{0, 4}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
