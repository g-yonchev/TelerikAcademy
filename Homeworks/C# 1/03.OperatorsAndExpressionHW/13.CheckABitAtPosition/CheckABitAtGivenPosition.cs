using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        /*  Problem 13. Check a Bit at Given Position

            Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
            Examples:

            n	    binary representation of n	    p	bit @ p == 1
            5	    00000000 00000101	            2	true
            0	    00000000 00000000	            9	false
            15	    00000000 00001111	            1	true
            5343	00010100 11011111	            7	true
            62241	11110011 00100001	            11	false
        */

        Console.Title = "Check a Bit at Given Position";

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter positon of a bit: ");
        int bitPosition = int.Parse(Console.ReadLine());

        string inBinary = Convert.ToString(number, 2).PadLeft(16, '0');
        Console.WriteLine("Your number in binary is: {0}", inBinary);

        int mask = 1 << (bitPosition);
        int numberAndMask = number & mask;
        int bit = numberAndMask >> bitPosition;
        bool isOne = bit == 1;
        Console.WriteLine("The bit #{0} has value 1? {1}", bitPosition, isOne);
    }
}