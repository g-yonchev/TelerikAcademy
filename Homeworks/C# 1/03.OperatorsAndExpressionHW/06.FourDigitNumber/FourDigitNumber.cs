using System;

class FourDigitNumber
{
    static void Main()
    {
        /*  Problem 6. Four-Digit Number

            Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
            Prints on the console the number in reversed order: dcba (in our example 1102).
            Puts the last digit in the first position: dabc (in our example 1201).
            Exchanges the second and the third digits: acbd (in our example 2101).
            The number has always exactly 4 digits and cannot start with 0.

            Examples:

            n	    sum of digits	reversed	last digit in front	    second and third digits exchanged
            2011	4	            1102	    1201	                2101
            3333	12	            3333	    3333	                3333
            9876	30	            6789	    6987	                9786
        */

        Console.Title = "Four-Digit Number";
        
        Console.Write("Enter a four-digit number: ");
        int number = int.Parse(Console.ReadLine());

        if (Math.Abs(number) > 10000 && Math.Abs(number) < 999)
        {
            Console.WriteLine("Wrong number. Please try again later.");
        }
        else
        {
            int fourthDigit = number % 10;
            int thirdtDigit = (number / 10) % 10;
            int secondtDigit = (number / 100) % 10;
            int firstDigit = (number / 1000) % 10;

            int sum = firstDigit + secondtDigit + thirdtDigit + fourthDigit;
            int reversedNumber = fourthDigit * 1000 + thirdtDigit * 100 + secondtDigit * 10 + firstDigit;
            int lastDigitFirst = fourthDigit * 1000 + firstDigit * 100 + secondtDigit * 10 + thirdtDigit;
            int exchangeSecondAndThird = firstDigit * 1000 + thirdtDigit * 100 + secondtDigit * 10 + fourthDigit;

            Console.WriteLine("The sum of the digits is: {0}", sum);
            Console.WriteLine("Reversed number: {0}", reversedNumber);
            Console.WriteLine("Last digit first: {0}", lastDigitFirst);
            Console.WriteLine("Exchange second and third: {0}", exchangeSecondAndThird);
        }
        
    }
}
