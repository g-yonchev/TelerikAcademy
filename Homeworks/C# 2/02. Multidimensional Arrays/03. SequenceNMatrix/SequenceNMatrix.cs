namespace SequenceNMatrix
{
    using System;
    using System.Collections.Generic;
    class SequenceNMatrix
    {
        /*  Problem 3. Sequence n matrix

            We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
            Write a program that finds the longest sequence of equal strings in the matrix.
        */

        static void Main()
        {

            string[,] matrix =
            {
                { "ha", "ho", "ho", "ho" },
                { "f", "ha", "d", "dsd" },
                { "xxx", "ho", "ha", "xx" }
            };

            int maxSum = 0;
            List<string> results = new List<string>();

            
            for (int id0 = 0; id0 < matrix.GetLength(0) - 1; id0++)
            {
                for (int id1 = 0; id1 < matrix.GetLength(1) - 1; id1++)
                {
                    int horSum = 1;
                    for (int i = 0; i < matrix.GetLength(1) - id1 - 1; i++)
                    {
                        if (matrix[id0, id1 + i] == matrix[id0, id1 + i + 1])
                        {
                            horSum++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (maxSum < horSum)
                    {
                        maxSum = horSum;
                        results.Clear();
                        results.Add(matrix[id0, id1]);
                    }
                    else if (maxSum == horSum)
                    {
                        results.Add(matrix[id0, id1]);
                    }

                    int diagSum = 1;
                    int limit = (matrix.GetLength(0) > matrix.GetLength(1)) ? matrix.GetLength(1) - id1 : matrix.GetLength(0) - id0;
                    for (int i = 0; i < limit - 1; i++)
                    {
                        if (matrix[id0 + i, id1 + i] == matrix[id0 + i + 1, id1 + i + 1])
                        {
                            diagSum++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (maxSum < diagSum)
                    {
                        maxSum = diagSum;
                        results.Clear();
                        results.Add(matrix[id0, id1]);
                    }
                    else if (maxSum == diagSum)
                    {
                        results.Add(matrix[id0, id1]);
                    }

                    int vertSum = 1;
                    for (int i = 0; i < matrix.GetLength(0) - id0 - 1; i++)
                    {
                        if (matrix[id0 + i, id1] == matrix[id0 + i + 1, id1])
                        {
                            vertSum++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (maxSum < vertSum)
                    {
                        maxSum = vertSum;
                        results.Clear();
                        results.Add(matrix[id0, id1]);
                    }
                    else if (maxSum == vertSum)
                    {
                        results.Add(matrix[id0, id1]);
                    }
                }
            }

            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine("\"{0}\" repeats {1} times", results[i], maxSum);
            }
        }
    }
}
