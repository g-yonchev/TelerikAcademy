using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        /*  Problem 10.* Beer Time

            A beer time is after 1:00 PM and before 3:00 AM.
            Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
            Examples:

            time	    result
            1:00 PM	    beer time
            4:30 PM	    beer time
            10:57 PM	beer time
            08:30 AM    non-beer time
            02:59 AM	beer time
            03:00 AM	non-beer time
            03:26 AM	non-beer time
         */

        Console.Title = "Beer time";
        
        Console.Write("Enter time when you want to drink a beer with friends (exp. 09:30 pm): ");
        string seceltedTime = Console.ReadLine();

        try
        {
            DateTime dateTime = DateTime.ParseExact(seceltedTime, "h:mm tt",
                                    CultureInfo.InvariantCulture);
            TimeSpan time = dateTime.TimeOfDay;
            TimeSpan startTime = new TimeSpan(13, 0, 0);
            TimeSpan endTime = new TimeSpan(03, 0, 0);

            if ((time >= startTime) || (time < endTime))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("invalid time");
        }
    }
}