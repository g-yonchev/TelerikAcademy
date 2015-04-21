using System;
class QuadraticEquation
{
    static void Main()
    {
        /*  Problem 6. Quadratic Equation

            Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
            Examples:

            a	    b	    c	    roots
            2	    5	    -3	    x1=-3; x2=0.5
            -1	    3	    0	    x1=3; x2=0
            -0.5	4	    -8	    x1=x2=4
            5	    2	    8	    no real roots
        */

        Console.Title = "Quadratic Equation";
        Console.WriteLine("You are given a quadratic equation ax2 + bx + c = 0.");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - 4 * a * c;
        if (discriminant < 0)
        {
            Console.WriteLine("There is no real roots.");
        }
        else
        {
            double discriminantRoot = Math.Sqrt(discriminant);
            double x1 = (-b + discriminantRoot) / (2 * a);
            double x2 = (-b - discriminantRoot) / (2 * a);
            Console.WriteLine(x1 == x2 ? "The Equasion got one real root x1 = x2 = {0}" : "The Equasion got two real roots x1 = {0}; x2 = {1}", x1, x2);
        }
    }
}