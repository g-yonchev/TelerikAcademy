using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Task3
{
    static void Main()
    {
        int[] mn = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int[,] grid = new int[mn[0], mn[1]];



        int rows = 0;
        int cols = 0;
        int value = 0;



        if (mn[0] <= mn[1])
        {
            for (int i = mn[0] - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < mn[0] && cols < mn[0])
                {
                    grid[rows++, cols++] = value;
                }
                value += 3;
            }

            for (int j = 1; j < mn[1]; j++)
            {
                rows = j;
                cols = 0;
                while (rows < mn[1] && cols < mn[1])
                {
                    grid[cols++, rows++] = value;
                }
                value += 3;
            }
        }
        else
        {
            for (int i = mn[0] - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < mn[0] && cols < mn[0])
                {
                    if (cols > grid.GetLength(1) - 1)
                    {
                        break;
                    } 
                    grid[rows++, cols++] = value;
                    
                }
                value += 3;
            }

            for (int j = 1; j < mn[1]; j++)
            {
                rows = j;
                cols = 0;
                while (rows < mn[1] && cols < mn[1])
                {
                    grid[cols++, rows++] = value;
                }
                value += 3;
            }
        }





        int number = int.Parse(Console.ReadLine());


        int allSum = 0;

        int currentRow = grid.GetLength(0) - 1;
        int currentCol = 0;

        for (int i = 0; i < number; i++)
        {
            string[] line = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string direction = line[0];
            int steps = int.Parse(line[1]);


            // do check outside the grid
            if (direction == "RU" || direction == "UR")
            {
                for (int j = 0; j < steps; j++)
                {
                    allSum += grid[currentRow, currentCol];

                    grid[currentRow, currentCol] = 0;

                    currentRow--;
                    currentCol++;
                    // !!!!
                    if (currentRow < 0 || currentCol > grid.GetLength(1) - 1)
                    {
                        break;
                    }
                }
                currentRow++;
                currentCol--;
            }

            if (direction == "LU" || direction == "UL")
            {
                for (int j = 0; j < steps; j++)
                {
                    allSum += grid[currentRow, currentCol];

                    grid[currentRow, currentCol] = 0;

                    currentRow--;
                    currentCol--;
                    // !!!!
                    if (currentRow < 0 || currentCol < 0)
                    {
                        break;
                    }
                }
                currentRow++;
                currentCol++;
            }

            if (direction == "DL" || direction == "LD")
            {
                for (int j = 0; j < steps; j++)
                {
                    allSum += grid[currentRow, currentCol];

                    grid[currentRow, currentCol] = 0;

                    currentRow++;
                    currentCol--;
                    // !!!!
                    if (currentRow > grid.GetLength(0) - 1 || currentCol < 0)
                    {
                        break;
                    }
                }
                currentRow--;
                currentCol++;
            }

            if (direction == "DR" || direction == "RD")
            {
                for (int j = 0; j < steps; j++)
                {
                    allSum += grid[currentRow, currentCol];

                    grid[currentRow, currentCol] = 0;

                    currentRow++;
                    currentCol++;
                    // !!!!
                    if (currentRow > grid.GetLength(0) - 1 || currentCol > grid.GetLength(1) - 1)
                    {
                        break;
                    }
                }
                currentRow--;
                currentCol--;
            }
        }

        Console.WriteLine(allSum);

    }
}
