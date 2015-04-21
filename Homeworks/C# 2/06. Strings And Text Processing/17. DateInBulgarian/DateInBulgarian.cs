/*  Problem 17. Date in Bulgarian

    Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/
namespace DateInBulgarian
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;
    class DateInBulgarian
    {
        static void Main()
        {
            Console.WriteLine("Enter date and time (in format: 02.03.2011 15:30:44): ");
            string input = Console.ReadLine();

            //string format = "d.M.yyyy hh:mm:ss";
            //CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime date = DateTime.Parse(input);
            date = date.AddHours(6);
            date = date.AddMinutes(30);

            Console.WriteLine(date.DayOfWeek);
            Console.WriteLine(date);

        }
    }
}
