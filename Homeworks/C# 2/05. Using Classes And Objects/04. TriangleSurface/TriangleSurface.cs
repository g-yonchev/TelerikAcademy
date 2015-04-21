/*  Problem 4. Triangle surface

    Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
    Use System.Math.
*/

namespace TriangleSurface
{
    using System;
    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("Surface of a triangle");

            CalculateBySideAndAltitude();

            CalculateByThreeSides();

            CalculateByTwoSidesAndAngle();
        }

        static void CalculateBySideAndAltitude()
        {
            Console.Write("Enter a side: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter an altitude: ");
            double altitude = double.Parse(Console.ReadLine());

            double S = (side * altitude) / 2;
            Console.WriteLine("Surface: " + S);

            Console.WriteLine();
        }

        static void CalculateByThreeSides()
        {
            Console.Write("Enter side A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter side B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter side C: ");
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c) );

            Console.WriteLine("Surface: {0:F5}", S);

            Console.WriteLine();
        }

        static void CalculateByTwoSidesAndAngle()
        {
            Console.Write("Enter side A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter side B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter an angel (in degrees) between them: ");
            double angleInDegrees = double.Parse(Console.ReadLine());

            double angleInRadians = (Math.PI / 180) * angleInDegrees;

            double S = ( a * b * (Math.Sin(angleInRadians)) / 2);

            Console.WriteLine("Surface: {0:F5}", S);

            Console.WriteLine();

        }
    }
}
