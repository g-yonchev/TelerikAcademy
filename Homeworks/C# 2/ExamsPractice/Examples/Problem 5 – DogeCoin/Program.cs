using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] nm = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int N = nm[0];
        int M = nm[1];

        int number = int.Parse(Console.ReadLine());

        ulong[,] grid = new ulong[N + 1, M + 1];

        for (int n = 0; n < number; n++)
        {
            int[] coin = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            int coinX = coin[0];
            int coinY = coin[1];

            grid[coinX + 1, coinY + 1]++;

        }

        for (int i = 1; i < N+1; i++)
        {
            for (int j = 1; j < M+1; j++)
            {
                ulong maxCurrentCoins = 0;
                if (grid[i-1,j] >= grid[i,j-1])
                {
                    maxCurrentCoins = grid[i - 1, j];
                }
                else
                {
                    maxCurrentCoins = grid[i, j - 1];
                }
                grid[i, j] += maxCurrentCoins;
            }
        }

        Console.WriteLine(grid[N, M]);
    }
}