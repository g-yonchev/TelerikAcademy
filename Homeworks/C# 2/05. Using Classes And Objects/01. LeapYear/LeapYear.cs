/*  Problem 1. Leap year

    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
*/

namespace LeapYear
{
    using System;
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter an year: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(year);
            Console.WriteLine("The year {0} is leap? --> {1}", year, isLeap ? "Yes": "No");            
        }
    }
}
