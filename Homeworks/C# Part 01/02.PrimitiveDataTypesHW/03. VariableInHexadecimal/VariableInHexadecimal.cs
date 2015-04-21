using System;

class VariableInHexadecimal
{
    static void Main()
    {
        /*  Problem 3. Variable in Hexadecimal Format

            Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
            Use Windows Calculator to find its hexadecimal representation.
            Print the variable and ensure that the result is 254.
        */

        Console.Title = "Variable in Hexadecimal";

        int number = 0xFE;
        Console.WriteLine("\'FE\' in decimal is {0}", number);

    }
}
