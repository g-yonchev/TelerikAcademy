using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            int[] lines = new int[N];

            int diagonal = 0;

            for (int i = 0; i < N; i++)
            {
                lines = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x))
                    .ToArray();

                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = lines[j];
                    
                }
                diagonal += matrix[i, i];
            }

            int sum = int.MinValue;
            int bestSum = int.MinValue;
            bool isPatter = false;

            for (int i = 0; i < N - 2; i++)
            {
                for (int j = 0; j < N - 4; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] - 1 &&
                        matrix[i, j + 1] == matrix[i, j + 2] - 1 &&
                        matrix[i, j + 2] == matrix[i + 1, j + 2] - 1 &&
                        matrix[i + 1, j + 2] == matrix[i + 2, j + 2] - 1 &&
                        matrix[i + 2, j + 2] == matrix[i + 2, j + 3] - 1 &&
                        matrix[i + 2, j + 3] == matrix[i + 2, j + 4] - 1)
                    {
                        sum =
                            matrix[i, j] +
                            matrix[i, j + 1] +
                            matrix[i, j + 2] +
                            matrix[i + 1, j + 2] +
                            matrix[i + 2, j + 2] +
                            matrix[i + 2, j + 3] +
                            matrix[i + 2, j + 4];
                        if (bestSum < sum)
                        {
                            bestSum = sum;
                            isPatter = true;

                        }
                    }
                }
            }

            if (isPatter)
            {
                Console.WriteLine("YES " + bestSum);
            }
            else
            {
                Console.WriteLine("NO " + diagonal);
            }
        }
    }
}
