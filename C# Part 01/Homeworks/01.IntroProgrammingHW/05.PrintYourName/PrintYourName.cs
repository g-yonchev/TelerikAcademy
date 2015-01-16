using System;

class PrintYourName
{
    static void Main()
    {
        /*  Problem 5. Print Your Name

            Modify the previous application to print your name.
            Ensure you have named the application well (e.g. “PrintMyName”).
        */

        Console.Title = "Print Your Name";

        Console.WriteLine("Pesho.");
        Console.WriteLine("My name is Pesho.");

        // Another ways. Creat string named firstName. With value Pesho. And the print it.

        string firtsName = "Pesho";
        Console.WriteLine("My name is " + firtsName + ".");
        Console.WriteLine("My name is {0}.", firtsName);
    }
}
