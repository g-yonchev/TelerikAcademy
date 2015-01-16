using System;

class NullValuesArithmetic
{
    static void Main()
    {
        /*  Problem 12. Null Values Arithmetic

            Create a program that assigns null values to an integer and to a double variable.
            Try to print these variables at the console.
            Try to add some number or the null literal to these variables and print the result.
        */

        Console.Title = "Null values arithmetic";

        int? nullInteger = null;
        double? nullDouble = null;
        Console.WriteLine("Integer with null value:{0}.", nullInteger);
        Console.WriteLine("Double with null value:{0}.", nullDouble);
        nullInteger = 23;
        nullDouble = 23.2d;
        Console.WriteLine("Integer with some value:{0}.", nullInteger);
        Console.WriteLine("Double with some value:{0}.", nullDouble);

        // Cannot implicitly convert type 'string' to 'int'
        // nullInteger = "null";
        // nullDouble = "null";
    }
}
