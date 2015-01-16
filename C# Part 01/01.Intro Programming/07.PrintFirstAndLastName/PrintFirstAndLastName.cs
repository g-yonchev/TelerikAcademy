using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        /*  Problem 7. Print First and Last Name

            Create console application that prints your first and last name, each at a separate line.
        */

        Console.Title = "Print full name";

        Console.WriteLine("Ivan");
        Console.WriteLine("Ivanov");
        
        // Another way. Creat two strings with values and print them.

        string firstName = "Ivan";
        string lastName = "Ivanov";
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        // Another way.

        Console.WriteLine(firstName + "\n\b" + lastName);

    }
}
