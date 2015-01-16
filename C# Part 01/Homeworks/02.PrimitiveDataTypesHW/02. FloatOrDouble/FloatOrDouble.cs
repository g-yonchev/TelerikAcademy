using System;

class FloatOrDouble
{
    static void Main()
    {
        /* Problem 2. Float or Double?

            Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
            Write a program to assign the numbers in variables and print them to ensure no precision is lost.
        */

        Console.Title = "Float or double?";

        double firstVariable = 34.567839023d;
        float secondVariable = 12.345f;
        double thirdVariable = 8923.1234857d;
        float fourthVariable = 3456.091f;
        Console.WriteLine("double: {0}", firstVariable);
        Console.WriteLine("float: {0}", secondVariable);
        Console.WriteLine("double: {0}", thirdVariable);
        Console.WriteLine("float: {0}", fourthVariable);
    }
}
