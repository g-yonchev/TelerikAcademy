using System;

class ExchangeValues
{
    static void Main()
    {
        /*  Problem 9. Exchange Variable Values

            Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
            Print the variable values before and after the exchange.
        */

        Console.Title = "Exchange variable values";

        int a = 5;
        int b = 10;
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
        a = a + b; // a = 15
        b = a - b; // b = 15 - 10 = 5
        a = a - b; // a = 15 - 5 = 10
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
    }
}
