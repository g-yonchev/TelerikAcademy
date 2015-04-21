/*  Problem 16. Date difference

    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
    Example:

    Enter the first date: 27.02.2006
    Enter the second date: 3.03.2006
    Distance: 4 days
*/

namespace DateDifference
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;
    class DateDifference
    {
        static void Main()
        {
            string format = "d.M.yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;


            Console.Write("Enter the first date (27.02.2006): ");
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), format, provider);

            Console.Write("Enter the second date (3.03.2006): ");
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), format, provider);

            Console.WriteLine("Distance: {0} days.", (endDate - startDate).TotalDays);
        }
    }
}
