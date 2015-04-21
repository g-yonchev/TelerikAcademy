using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = 1; // int.Parse(Console.ReadLine());
        int width = 2 * n + 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(new string('.', ));
                Console.Write('\\');
                Console.Write('#');
                Console.Write('\\');

                Console.Write('.');

                Console.Write('/');
                Console.Write('#');
                Console.Write('/');
                Console.Write('.');
                
            }
            Console.WriteLine();
        }

    }
}