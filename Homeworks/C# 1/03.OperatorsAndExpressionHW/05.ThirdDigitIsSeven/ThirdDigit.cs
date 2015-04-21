using System;

class ThirdDigit
{
    static void Main()
    {
        /*  Problem 5. Third Digit is 7?

            Write an expression that checks for given integer if its third digit from right-to-left is 7.
            Examples:

            n	    Third digit 7?
            5	    false
            701	    true
            9703	true
            877	    false
            777877	false
            9999799	true
        */

        Console.Title = "Third Digit is 7";

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int sevenDigit = (number / 100) % 10;
        bool isSeven = (Math.Abs(sevenDigit) == 7);
        Console.WriteLine("The third digit is 7? {0}", isSeven);
    }
}
