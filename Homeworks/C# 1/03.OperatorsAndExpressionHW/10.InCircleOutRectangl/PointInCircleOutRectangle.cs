using System;

class PointInCircleOutRectangle
{
    static void Main()
    {
        /*  Problem 10. Point Inside a Circle & Outside of a Rectangle

            Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
            Examples:

            x	    y	    inside K & outside of R
            1	    2	    yes
            2.5	    2	    no
            0	    1	    no
            2.5	    1	    no
            2	    0	    no
            4	    0	    no
            2.5	    1.5	    no
            2	    1.5	    yes
            1	    2.5	    yes
            -100	-100	no
        */

        Console.Title = "Point in circle & out of rectangle";

        Console.WriteLine("You are given a circle K({1, 1}, 1.5) and rectangle R(top=1, left=-1, width=6,  height=2. Enter coordinates of a point (x, y).");
        Console.WriteLine();
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        bool inCircle = (Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2)) <= Math.Pow(1.5, 2);
        bool inRectangle = y >= 1;
        bool inCircleOutRectangle = inCircle && inRectangle;

        Console.WriteLine("The point ({0}, {1}) is in the circle and out of the rectangle? --> {2}.", x, y, inCircleOutRectangle);
    }
}