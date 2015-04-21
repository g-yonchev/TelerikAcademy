namespace FillTheMatrix
{
    using System;
    class FillTheMatrix
    {
        /*  Problem 1. Fill the matrix

            Write a program that fills and prints a matrix of size (n, n) as shown below:
            Example for n=4:

            d)
            1	12	11	10
            2	13	16	9
            3	14	15	8
            4	5	6	7
        */

        static void Main()
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int number = 1;

            
            for (int i = 0; i < n; i++) 
            {
                for (int j = i; j < n - i; j++)
                {
                    matrix[i, j] = number;
                    number++;

                }

                for (int j = 0; j < n - 1 - i * 2; j++)
                {
                    matrix[j + 1 + i, n - i - 1] = number;
                    number++;
                }


                for (int j = 0; j < n - 1 - i * 2; j++) 
                {
                    matrix[n - 1 - i, n - j - 2 - i] = number;
                    number++;
                }


                for (int j = 0; j < n - 2 - i * 2; j++)
                {
                    matrix[n - j - 2 - i, i] = number;
                    number++;
                }
            }


            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
