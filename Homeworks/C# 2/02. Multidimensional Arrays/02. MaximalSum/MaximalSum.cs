namespace MaximalSum
{
    using System;
    using System.Linq;
    class MaximalSum
    {
        /*  Problem 2. Maximal sum

            Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
        */

        static void Main()
        {
            Console.Write("Enter number of rows (N > 3): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Enter number of cols (M > 3): ");
            int M = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, M];

            Console.WriteLine("Enter {0} elements of every {1} rows separated by space and/or coma.", M, N);
            Console.WriteLine("And press Enter:");
            for (int i = 0; i < N; i++)
            {
                int[] row = Console.ReadLine()
                    .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int i = 0; i < N - 2; i++)
            {
                for (int j = 0; j < M - 2; j++)
                {
                    int currentRow = i;
                    int currentCol = j;
                    int currentSum =
                        matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (currentSum > maxSum)
                    {
                        bestRow = currentRow;
                        bestCol = currentCol;
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine("Best 3x3 submatrix: ");
            for (int i = bestRow; i < bestRow + 3; i++)
            {
                for (int j = bestCol; j < bestCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
