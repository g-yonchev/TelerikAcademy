namespace FillTheMatrix
{
    using System;
    class FillTheMatrix
    {
        /*  Problem 1. Fill the matrix

            Write a program that fills and prints a matrix of size (n, n) as shown below:
            Example for n=4:

            b)
            1	8	9	16
            2	7	10	15
            3	6	11	14
            4	5	12	13
        */

        static void Main()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            
            int counter = 1;
            int currentCounter = 1;

            for (int cols = 0; cols < n; cols++)
            {
                for (int rows = 0; rows < n; rows++)
                {
                    if (cols % 2 == 0)
                    {
                        matrix[rows, cols] = counter++;
                    }
                    else
                    {
                        matrix[rows, cols] = --counter;
                    }
                }
                if (cols % 2 == 0)
                {
                    currentCounter = counter;
                    currentCounter += n;
                    counter = currentCounter;
                }
                else
                {
                    counter = currentCounter;
                }
            }

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write("{0, 4}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
