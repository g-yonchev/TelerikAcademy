using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for (int i = 5; i < 8; i++)
        {
            int mask = ~(1 << i);
            s = s & mask;
        }

        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            // input

            int number = int.Parse(Console.ReadLine());
            int newNumber = number;
            for (int j = 0; j < 25; j++)
            {
                newNumber = number >> j;
                if ((newNumber & 31) == s) // !!!!!!!!!!!! dopulni
                {
                    counter++;
                }

            }
        }
        Console.WriteLine(counter);
     }
}