using System;

class Program
{
    static void Main()
    {

        // initialization

        int X = int.Parse(Console.ReadLine());
        int Y = X;
        int Z = (X / 2) + 1;

        int width = (2 * Z + 2 * X) - 3;
        int height = width;

        int[,] logo = new int[width, width];

        // solution --> filling the path with ones (1)

        int curentRow = X / 2;
        int curentCol = 0;

        while (true)
        {
            logo[curentRow, curentCol] = 1;
            curentCol++;
            curentRow--;
            if (curentRow < 0)
            {
                curentCol--;
                curentRow++;
                break;
            }
            
        }

        while (true)
        {
            logo[curentRow, curentCol] = 1;
            curentCol++;
            curentRow++;
            if (curentRow == 2 * X - 1)
            {
                curentCol--;
                curentRow--;
                break;
            }
        }

        while (true)
        {
            logo[curentRow, curentCol] = 1;
            curentCol--;
            curentRow++;
            if (curentRow >= width)
            {
                curentCol++;
                curentRow--;
                break;
            }
        }

        while (true)
        {
            logo[curentRow, curentCol] = 1;
            curentCol--;
            curentRow--;
            if (curentCol == Z - 2)
            {
                curentCol++;
                curentRow++;
                break;
            }
        }

        while (true)
        {
            logo[curentRow, curentCol] = 1;
            curentCol++;
            curentRow--;
            if (curentRow < 0)
            {
                curentCol--;
                curentRow++;
                break;
            }
        }

        while (true)
        {
            logo[curentRow, curentCol] = 1;
            curentCol++;
            curentRow++;
            if (curentCol >= width)
            {
                curentCol--;
                curentRow--;
                break;
            }
        }

        // printing

        for (int row = 0; row < width; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if (logo[row, col] == 0)
                {
                    Console.Write('.');
                }
                else if (logo[row, col] == 1)
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}