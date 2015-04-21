using System;

class SumOfNNumbers
{
    static void Main()
    {
        /*  Problem 9. Sum of n Numbers

            Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
        */

        Console.Title = "Sum of n Numbers";

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 1)
        {
            Console.WriteLine("Wrong number. Please try again later.");
        }
        else
        {
            Console.WriteLine("Enter {0} numbers: ", number);

            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
        
    }
}
