using System;

class Program
{
    static void Main()
    {
        int n = 8;

        int[,] matrix = new int[n, n];

        for (int row = 0; row < n; row++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int col = 0; col < n; col++)
            {
                int bit = (number >> col) & 1;
                matrix[row, col] = bit;
            }
        }

        int pillarIndex = 7;
        int countBitsLeft = 0;
        int countBitsRight = 0;
        bool foundSolution = false;

        while (pillarIndex >= 0)
        {
            for (int col = 0; col < pillarIndex; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    
                }
            }

            pillarIndex--;
        }

        if (foundSolution)
        {
            
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}