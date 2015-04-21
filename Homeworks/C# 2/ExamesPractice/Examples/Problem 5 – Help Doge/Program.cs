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

        int[] food = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int foodX = food[0];
        int foodY = food[1];

        BigInteger[,] grid = new BigInteger[N + 1, M + 1];

        int countEnemies = int.Parse(Console.ReadLine());

        bool[,] enemies = new bool[N + 1, M + 1];

        for (int i = 0; i < countEnemies; i++)
        {
            int[] enemy = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

            int enemyX = enemy[0];
            int enemyY = enemy[1];

            enemies[(enemyX + 1), (enemyY + 1)] = true;
        }


        for (int i = 1; i < N + 1; i++)
        {
            for (int j = 1; j < M + 1; j++)
            {
                if (i == 1 && j == 1)
                {
                    grid[i, j] = 1;
                    continue;
                }

                if (enemies[i,j] == true)
                {
                    grid[i, j] = 0;
                    continue;
                }

                grid[i, j] = grid[i, j - 1] + grid[i - 1, j];

            }
        }

        Console.WriteLine(grid[foodX+1,foodY+1]);
    }
}

