using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('.', n));
        Console.Write(new string('*', n));
        Console.WriteLine();

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', (n - 1) - i));
            Console.Write("*");
            Console.Write(new string('.', (n - 1) + i));
            Console.Write("*");
            Console.WriteLine();
        }
        
        
        Console.Write(new string('*', n * 2));
        Console.WriteLine();
    }
}