using System;

class UnicodeCharacter
{
    static void Main()
    {
        /*  Problem 4. Unicode Character

            Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
        */

        Console.Title = "Unicode character";

        char symbol = '\u002A';
        Console.WriteLine("The character with unicode code (decimal) 42 is: {0}.", symbol);
    }
}
