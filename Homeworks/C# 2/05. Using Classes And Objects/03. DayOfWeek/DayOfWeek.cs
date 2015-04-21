/*  Problem 3. Day of week

    Write a program that prints to the console which day of the week is today.
    Use System.DateTime.
*/

namespace DayOfWeek
{
    using System;
    class DayOfWeek
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is " + today.DayOfWeek);
        }
    }
}
