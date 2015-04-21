using System;

class StringsAndObjects
{
    static void Main()
    {
        /*  Problem 6. Strings and Objects

            Declare two string variables and assign them with Hello and World.
            Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
            Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
        */

        Console.Title = "Strings and Objects";

        string firstString = "Hello";
        string secondString = "World";
        object objectVariable = firstString + " " + secondString;
        string thirdString = (string)objectVariable;

        Console.WriteLine("Object: {0}", objectVariable);
        Console.WriteLine("String: {0}", thirdString);
    }
}
