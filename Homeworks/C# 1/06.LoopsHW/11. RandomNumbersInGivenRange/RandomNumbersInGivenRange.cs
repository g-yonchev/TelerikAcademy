using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        /*  Problem 11. Random Numbers in Given Range

            Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
            
            Examples:
            n	min	max	    random numbers
            5	0	1	    1 0 0 1 1
            10	10	15	    12 14 12 15 10 12 14 13 13 11
            
            Note: The above output is just an example. Due to randomness, your program most probably will produce different results.
        */

        Console.Title = "Random numbers";

        Console.Write("Enter n: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        if (max < min) // change their positions
        {
            max = max + min;
            min = max - min;
            max = max - min;
        }

        Console.WriteLine();

        Random random = new Random();
        Console.WriteLine("{0} random numbers between {1} and {2}:", number, min, max);
        for (int i = 0; i < number; i++)
        {
            int randomNumber = random.Next(min, max + 1);
            Console.Write("{0} ", randomNumber);
        }
        Console.WriteLine();
    }
}