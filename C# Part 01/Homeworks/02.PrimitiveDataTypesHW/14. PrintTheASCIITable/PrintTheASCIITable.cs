using System;

class PrintTheASCIITable
{
    static void Main()
    {
        /*  Problem 14.* Print the ASCII Table

            Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
        */

        Console.Title = "ASCII table";

        for (int i = 0; i <= 255; i++)
        {
            char symbol = Convert.ToChar(i);
            Console.WriteLine("{0,3}: {1}", i, symbol);
        }
    }
}
