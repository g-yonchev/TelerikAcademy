using System;

class SpiralMatrix
{
    static void Main()
    {
        /*  Problem 19.** Spiral Matrix

            Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
            Examples:

            n = 2   matrix           n = 3   matrix          n = 4   matrix
                    1 2                      1 2 3                   1  2  3  4
                    4 3                      8 9 4                   12 13 14 5
                                             7 6 5                   11 16 15 6
                                                                     10 9  8  7
        */

        Console.Title = "Spiral matrix";

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int[,] matrix = new int[number, number];

        string direction = "right";

        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= number * number; i++)
        {
            if (direction == "right" && (currentCol >= number || matrix[currentRow, currentCol] != 0))
            {
                direction = "down";
                currentCol--;
                currentRow++;
            }
            else if (direction == "down" && (currentRow >= number || matrix[currentRow, currentCol] != 0))
            {
                direction = "left";
                currentCol--;
                currentRow--;
            }
            else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                direction = "up";
                currentCol++;
                currentRow--;
            }
            else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
            {
                direction = "right";
                currentRow++;
                currentCol++;
            }

            matrix[currentRow, currentCol] = i;

            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write("{0,5}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}