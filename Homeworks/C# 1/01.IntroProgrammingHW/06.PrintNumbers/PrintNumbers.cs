using System;

class PrintNumbers
{
    static void Main()
    {
        /*  Problem 6. Print Numbers

            Write a program to print the numbers 1, 101 and 1001, each at a separate line.
            Name the program correctly.
        */

        Console.Title = "Print numbers";

        Console.WriteLine("1");
        Console.WriteLine("101");
        Console.WriteLine("1001");

        // Another way.

        int a = 1;
        int b = 101;
        int c = 1001;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
