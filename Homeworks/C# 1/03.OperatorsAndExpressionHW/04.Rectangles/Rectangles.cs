using System;

class Rectangles
{
    static void Main()
    {
        /* Problem 4. Rectangles

        Write an expression that calculates rectangle’s perimeter and area by given width and height.
        Examples:

        width	height	perimeter	area
        3	    4	    14	        12
        2.5	    3	    11	        7.5
        5	    5	    20	        25
        
        */

        Console.Title = "Rectangels";

        Console.Write("Wight: ");
        double wight = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (wight + height);
        double area = wight * height;
        Console.WriteLine("Perimeter is {0}. Area is {1}", perimeter, area);
    }
}

