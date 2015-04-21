using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[8, 16];

        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int j = 0; j < 16; j++)
            {
                int mask = 1 << j;
                int nAndMask = number & mask;
                int bit = nAndMask >> j;
                matrix[i, j] = bit;
            }
        }

        for (int col = 8; col < 16; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    break;
                }
            }


        }
    }
}