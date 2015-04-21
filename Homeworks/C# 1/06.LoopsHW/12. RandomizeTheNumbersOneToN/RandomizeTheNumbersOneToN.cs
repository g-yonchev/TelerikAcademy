using System;

class RandomizeTheNumbersOneToN
{
    static void Main()
    {
        /*  Problem 12.* Randomize the Numbers 1…N

            Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
         
            Examples:
            n	    randomized numbers 1…n
            3	    2 1 3
            10	    3 4 8 2 6 7 9 1 10 5
         
            Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.
         */

        Console.Title = "Randomize the Numbers 1…N";

        Console.Write("Enter n: ");
        int number = int.Parse(Console.ReadLine());
        
        int[] matrix = new int[number];
        bool[] printed = new bool[number + 1];
        
        Random random = new Random();
        int randomNumber = random.Next(1, number + 1); 
        for (int i = 0; i < number; i++)
        {
            randomNumber = random.Next(1, number + 1);
            if (!printed[randomNumber])
            {
                Console.Write("{0} ", randomNumber);
                printed[randomNumber] = true;
            }
            else
            {
                i--;
            }
        }
        Console.WriteLine();
    }
}