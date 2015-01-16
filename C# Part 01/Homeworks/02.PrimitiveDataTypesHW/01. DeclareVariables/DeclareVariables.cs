using System;

class DeclareVariables
{
    static void Main()
    {
        /*  Problem 1. Declare Variables

            Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
            Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
        */

        Console.Title = "Declare variables";

        ushort firstVariable = 52130;
        sbyte secondVariable = -115;
        int thirdVariable = 4825932;
        byte fourthVariable = 97;
        short fifthVariable = -10000;
        Console.WriteLine("ushort: {0}", firstVariable);
        Console.WriteLine("sbyte: {0}", secondVariable);
        Console.WriteLine("int: {0}", thirdVariable);
        Console.WriteLine("byte: {0}", fourthVariable);
        Console.WriteLine("short: {0}", fifthVariable);
    }
}
