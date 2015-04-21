
// Ne pitai :D :) moi si logiki :D


using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine()); // n = 5

        char dot = '.';
        char boat = '*';

        Console.Write(new string(dot, N));
        Console.Write(new string(boat, 1));
        Console.WriteLine(new string(dot, N));

        for (int i = N - 1; i > 0; i--) // i = 4,3,2,1
        {
            Console.Write(new string(dot, i));
            Console.Write("*");
            Console.Write(new string(dot, (N -1) - i));
            Console.Write("*");
            Console.Write(new string(dot, (N - 1) - i));
            Console.Write("*");
            Console.WriteLine(new string(dot, i));            
        }

        Console.WriteLine(new string(boat, N * 2 + 1));

        for (int i = 0; i <= (N - 3) / 2; i++)
        {
            Console.Write(new string(dot, i + 1));
            Console.Write(boat);
            Console.Write(new string(dot, (N -2) - i));
            Console.Write(boat);
            Console.Write(new string(dot, (N - 2) - i));
            Console.Write(boat);
            Console.WriteLine(new string(dot, i + 1));
        }

        Console.Write(new string(dot, (N * 2 + 1 - N) / 2));
        Console.Write(new string(boat, N));
        Console.Write(new string(dot, (N * 2 + 1 - N) / 2));

        if (N % 2 == 0)
        {
            Console.WriteLine(".");
        }
        else
        {
            Console.WriteLine();
        }
    }
}
