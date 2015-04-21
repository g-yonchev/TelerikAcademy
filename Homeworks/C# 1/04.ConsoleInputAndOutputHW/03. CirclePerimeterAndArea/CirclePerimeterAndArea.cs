using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        /*  Problem 3. Circle Perimeter and Area

            Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
            Examples:

            r	    perimeter	area
            2	    12.57	    12.57
            3.5	    21.99       38.48
        */

        Console.Title = "Circle Perimeter and Area";

        Console.Write("Please, enter radius (r): ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("The perimeter of a circle with radius {0} is: {1:F2}", radius, perimeter);
        Console.WriteLine("The area of a circle with radius {0} is: {1,10:F2}", radius, area);
    }
}