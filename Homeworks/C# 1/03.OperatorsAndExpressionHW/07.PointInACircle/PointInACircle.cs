using System;

class PointInACircle
{
    static void Main()
    {
        /*  Problem 7. Point in a Circle

            Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
            Examples:

            x	    y	    inside
            0	    1	    true
            -2	    0	    true
            -1	    2	    false
            1.5	    -1	    true
            -1.5	-1.5	false
            100	    -30	    false
            0	    0	    true
            0.2	    -0.8	true
            0.9	    -1.93	false
            1	    1.655	true
        */

        Console.Title = "Point in a circle";

        Console.WriteLine("You are given a circle K({0, 0}, 2). Enter coordinates of a point (x, y).");
        Console.WriteLine();
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double radius = 2;

        bool isInACircle = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2);
        Console.WriteLine("The point ({0}, {1}) is in the circle? --> {2}", x, y, isInACircle);
    }
}