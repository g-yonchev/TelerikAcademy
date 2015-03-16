namespace Euclidian3D
{
    using System;

    public class Program
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(1.3, 2.2, 3.3);
            Point3D secondPoint = new Point3D(1, 3, 4);
            Console.WriteLine(Distance.CalculateDistance(firstPoint,secondPoint));
            Path path = new Path();
            Console.WriteLine(path);
            path.AddPoint(firstPoint);
            path.AddPoint(secondPoint);
            Console.WriteLine(path);
            
        }
    }
}
