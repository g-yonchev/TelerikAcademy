 using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        /*  Problem 3. Divide by 7 and 5

            Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
            Examples:

            n	    Divided by 7 and 5?
            3	    false
            0	    false
            5	    false
            7	    false
            35	    true
            140	    true
         */

        Console.Title = "Divide by 7 and 5";

        Console.WriteLine("Enter a number. Is your number can be divided by 7 and 5?");
        int number = int.Parse(Console.ReadLine());
        int firstDivider = 5;
        int secondDivider = 7;
        Console.WriteLine((number % firstDivider == 0) && (number % secondDivider == 0) && number !=0);
    }
}
