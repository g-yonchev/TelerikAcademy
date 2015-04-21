using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

        string[] rows = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] cols = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        uint[,] matrix = new uint[N + 1, M + 1];

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= M; j++)
            {
                if (rows[i - 1] == cols[j - 1])
                {
                    matrix[i, j] = matrix[i - 1, j - 1] + 1;
                }
                else
                {
                    matrix[i, j] = Math.Max(matrix[i, j - 1], matrix[i - 1, j]);
                }
            }
        }
        Console.WriteLine(matrix[N,M]);
    }
}

