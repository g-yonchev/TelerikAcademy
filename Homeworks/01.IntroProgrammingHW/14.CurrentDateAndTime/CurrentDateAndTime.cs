using System;

class CurrentDateAndTime
{
    static void Main()
    {
        /*  Problem 14.* Current Date and Time

            Create a console application that prints the current date and time. Find out how in Internet.
        */

        Console.Title = "Current time";

        Console.WriteLine("The time is: {0}", DateTime.Now);
    }
}
