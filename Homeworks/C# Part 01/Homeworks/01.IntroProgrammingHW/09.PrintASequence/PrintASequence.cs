using System;

class PrintASequence
{
    static void Main()
    {
        /*  Problem 9. Print a Sequence

            Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
        */

        Console.Title = "Sequence";

        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(-i);
                if (i < 11)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine();
    }
}
