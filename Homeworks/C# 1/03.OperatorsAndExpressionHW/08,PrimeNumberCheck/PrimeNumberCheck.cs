using System;

class PrimeNumberCheck
{
    static void Main()
    {
        /* Problem 8. Prime Number Check

            Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
            Examples:

            n	Prime?
            1	false
            2	true
            3	true
            4	false
            9	false
            97	true
            51	false
            -3	false
            0	false
        */

        Console.Title = "Prime Number";

        Console.Write("Enter a positive integer number lesser or equal to 100: ");
        int number = int.Parse(Console.ReadLine());
        bool check = number >= 100;

        if (check)
        {
            Console.WriteLine("The number you have entered is invalid. Please try again later.");
        }
        else if ((number == 2 || number == 3 || number == 5 || number == 7)
                ^ (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0))
        {
            Console.WriteLine("The number is Prime");
        }
        else
            Console.WriteLine("The number is NOT Prime");
    }
}
