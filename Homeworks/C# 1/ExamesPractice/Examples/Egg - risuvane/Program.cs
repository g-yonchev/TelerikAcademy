using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n;
        int width = 3 * n + 1;
        int topAndBottom = n - 1;


        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                if ((col > n && col < width - n - 1)
                    && (row == 0 || row == height - 1))
                {
                    Console.Write('*');
                }
                else if ((col == 1 || col == width - 2)
                    && (row >= n / 2 && row < height - n / 2))
                {
                    Console.Write('*');
                }
                else if ((2 * row + col == n + 1)
                    || (2 * row + col == 6 * n - 3))
                {
                    Console.Write('*');
                }
                else if ((2 * row - col == 3 * n - 3)
                    || (2 * row - col == -(2 * n - 1)))
                {
                    Console.Write('*');
                }
                else if ((row == n - 1)
                    && (col > 1 && col < width - 2)
                    && (col % 2 == 0))
                {
                    Console.Write('@');
                }
                else if ((row == height - n)
                && (col > 1 && col < width - 2)
                && (col % 2 == 1))
                {
                    Console.Write('@');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}