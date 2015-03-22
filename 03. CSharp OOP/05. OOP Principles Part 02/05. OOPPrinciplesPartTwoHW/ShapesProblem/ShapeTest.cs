/*  Problem 1. Shapes

    Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
    Define class Circle and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
    Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Circle, Rectangle, Triangle) stored in an array.
*/

namespace ShapesProblem
{
    using System;
    using System.Collections.Generic;

    class ShapeTest
    {
        private static readonly Random random = new Random();

        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < 5; i++)
            {
                Circle currentCircle = new Circle(RandomNumberBetween(1,10));
                Triangle currentTriange = new Triangle(RandomNumberBetween(1, 10), RandomNumberBetween(1, 10));
                Rectangle currentRectangle = new Rectangle(RandomNumberBetween(1, 10), RandomNumberBetween(1, 10));
                shapes.Add(currentCircle);
                shapes.Add(currentTriange);
                shapes.Add(currentRectangle);
            }

            PrintSurface(shapes);
        }

        private static void PrintSurface(IEnumerable<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }
    }
}
