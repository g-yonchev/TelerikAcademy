/*  Problem 2. Random numbers

    Write a program that generates and prints to the console 10 random values in the range [100, 200].
*/

namespace RandomNumbers
{
    using System;
    class RandomNumbers
    {
        static Random rand = new Random();

        static void Main()
        {
            Console.WriteLine("Ten random numbers between 100 and 200:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number {0, 2}: ", i +1);
                Console.WriteLine(rand.Next(100, 201).ToString());
            }
        }
    }
}
