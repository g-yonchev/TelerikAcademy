using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        decimal avr = 0;


        Console.WriteLine(Math.Max(Math.Max(a, b), c));
        Console.WriteLine(Math.Min(Math.Min(a, b), c));

        avr = (decimal)(a + b + c) / 3;
        Console.WriteLine("{0:F3}", avr);

    }
}