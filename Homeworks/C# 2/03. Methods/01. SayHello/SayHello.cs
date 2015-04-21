namespace _SayHello
{
    using System;
    class SayHello
    {
        /*  Problem 1. Say Hello

            Write a method that asks the user for his name and prints “Hello, <name>”
            Write a program to test this method
            
            Example:

            input	output
            Peter	Hello, Peter!
        */

        static void Main()
        {
            EnterName();
            int coins = 100;

            Pechalba(coins);

            Console.WriteLine(coins);
        }

        static void Pechalba(int coins)
        {
            coins +=10;
        }

        static void EnterName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
