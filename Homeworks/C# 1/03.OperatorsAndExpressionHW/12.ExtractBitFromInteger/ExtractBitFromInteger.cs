using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        /*  Problem 12. Extract Bit from Integer

            Write an expression that extracts from given integer n the value of given bit at index p.
            Examples:

            n	    binary representation	p	    bit @ p
            5	    00000000 00000101	    2	    1
            0	    00000000 00000000	    9	    0
            15	    00000000 00001111	    1	    1
            5343	00010100 11011111	    7	    1
            62241	11110011 00100001	    11	    0
        */

        Console.Title = "Extract Bit from Integer";

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter positon of a bit: ");
        int bitPosition = int.Parse(Console.ReadLine());

        string inBinary = Convert.ToString(number, 2).PadLeft(16, '0');
        Console.WriteLine("Your number in binary is: {0}", inBinary); // 5 = 00000000 00000'1'01 ; bit #2

        int mask = 1 << (bitPosition);
        int numberAndMask = number & mask;
        int bit = numberAndMask >> bitPosition;
        Console.WriteLine("The bit #{0} is: {1}", bitPosition, bit);


    }
}