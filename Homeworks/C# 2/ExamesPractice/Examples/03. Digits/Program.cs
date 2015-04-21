using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                int[] line = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            int sum = 0;

            for (int i = 0; i <= N - 5; i++)
            {
                for (int j = 0; j <= N - 3; j++)
                {
                    if (matrix[i + 2, j] == 1 &&
                        matrix[i + 1, j + 1] == 1 &&
                        matrix[i, j + 2] == 1 &&
                        matrix[i + 1, j + 2] == 1 &&
                        matrix[i + 2, j + 2] == 1 &&
                        matrix[i + 3, j + 2] == 1 &&
                        matrix[i + 4, j + 2] == 1)
                    {
                        sum += 1;
                    }

                    if (matrix[i + 1, j] == 2 &&
                        matrix[i, j + 1] == 2 &&
                        matrix[i + 1, j + 2] == 2 &&
                        matrix[i + 2, j + 2] == 2 &&
                        matrix[i + 3, j + 1] == 2 &&
                        matrix[i + 4, j] == 2 &&
                        matrix[i + 4, j + 1] == 2 &&
                        matrix[i + 4, j + 2] == 2)
                    {
                        sum += 2;
                    }

                    if (matrix[i, j] == 3 &&
                        matrix[i, j + 1] == 3 &&
                        matrix[i, j + 2] == 3 &&
                        matrix[i + 1, j + 2] == 3 &&
                        matrix[i + 2, j + 2] == 3 &&
                        matrix[i + 3, j + 2] == 3 &&
                        matrix[i + 4, j + 2] == 3 &&
                        matrix[i + 2, j + 1] == 3 &&
                        matrix[i + 4, j] == 3 &&
                        matrix[i + 4, j + 1] == 3)
                    {
                        sum += 3;
                    }

                    if (matrix[i, j] == 4 &&
                        matrix[i + 1, j] == 4 &&
                        matrix[i + 2, j] == 4 &&
                        matrix[i, j + 2] == 4 &&
                        matrix[i + 1, j + 2] == 4 &&
                        matrix[i + 2, j + 2] == 4 &&
                        matrix[i + 3, j + 2] == 4 &&
                        matrix[i + 4, j + 2] == 4 &&
                        matrix[i + 2, j + 1] == 4)
                    {
                        sum += 4;
                    }

                    if (matrix[i, j] == 5 &&
                        matrix[i, j + 1] == 5 &&
                        matrix[i, j + 2] == 5 &&
                        matrix[i + 1, j] == 5 &&
                        matrix[i + 2, j] == 5 &&
                        matrix[i + 2, j + 1] == 5 &&
                        matrix[i + 2, j + 2] == 5 &&
                        matrix[i + 3, j + 2] == 5 &&
                        matrix[i + 4, j + 2] == 5 &&
                        matrix[i + 4, j + 1] == 5 &&
                        matrix[i + 4, j] == 5)
                    {
                        sum += 5;
                    }

                    if (matrix[i, j] == 6 &&
                        matrix[i, j + 1] == 6 &&
                        matrix[i, j + 2] == 6 &&
                        matrix[i + 1, j] == 6 &&
                        matrix[i + 2, j] == 6 &&
                        matrix[i + 3, j] == 6 &&
                        matrix[i + 4, j] == 6 &&
                        matrix[i + 2, j + 1] == 6 &&
                        matrix[i + 2, j + 2] == 6 &&
                        matrix[i + 4, j + 1] == 6 &&
                        matrix[i + 4, j + 2] == 6 &&
                        matrix[i + 3, j + 2] == 6)
                    {
                        sum += 6;
                    }

                    if (matrix[i, j] == 7 &&
                        matrix[i, j + 1] == 7 &&
                        matrix[i, j + 2] == 7 &&
                        matrix[i + 1, j + 2] == 7 &&
                        matrix[i + 2, j + 1] == 7 &&
                        matrix[i + 3, j + 1] == 7 &&
                        matrix[i + 4, j + 1] == 7)
                    {
                        sum += 7;
                    }

                    if (matrix[i, j] == 8 &&
                        matrix[i, j + 1] == 8 &&
                        matrix[i, j + 2] == 8 &&
                        matrix[i + 1, j] == 8 &&
                        matrix[i + 1, j + 2] == 8 &&
                        matrix[i + 2, j + 1] == 8 &&
                        matrix[i + 3, j + 2] == 8 &&
                        matrix[i + 3, j] == 8 &&
                        matrix[i + 4, j] == 8 &&
                        matrix[i + 4, j + 1] == 8 &&
                        matrix[i + 4, j + 2] == 8)
                    {
                        sum += 8;
                    }

                    if (matrix[i, j] == 9 &&
                        matrix[i, j + 1] == 9 &&
                        matrix[i, j + 2] == 9 &&
                        matrix[i + 1, j] == 9 &&
                        matrix[i + 1, j + 2] == 9 &&
                        matrix[i + 2, j + 1] == 9 &&
                        matrix[i + 2, j + 2] == 9 &&
                        matrix[i + 3, j + 2] == 9 &&
                        matrix[i + 4, j] == 9 &&
                        matrix[i + 4, j + 1] == 9 &&
                        matrix[i + 4, j + 2] == 9)
                    {
                        sum += 9;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
