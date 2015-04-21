using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = n;
        int width = 2 * n;

        int update = 1;
        int currentRow = 1;
        for (int i = 0; i < n; i++)
        {
            var middleChar = '.';

            if (i == currentRow)
            {
                middleChar = '-';
                currentRow += update + 1;
                ++update;
            }
            Console.Write(new string('.', n - 1 - i));
            Console.Write('/');
            Console.Write(new string(middleChar, 2 * i));
            Console.Write('\\');
            Console.Write(new string('.', n - 1 - i));
            Console.WriteLine();
        }
    }
}