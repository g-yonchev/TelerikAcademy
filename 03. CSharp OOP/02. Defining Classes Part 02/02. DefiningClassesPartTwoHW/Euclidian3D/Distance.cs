namespace Euclidian3D
{
    public static class Distance
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            double result;
            double distanceX = System.Math.Pow((first.X - second.X), 2);
            double distanceY = System.Math.Pow((first.Y - second.Y), 2);
            double distanceZ = System.Math.Pow((first.Z - second.Z), 2);

            result = System.Math.Sqrt(distanceX + distanceY + distanceZ);

            return result;
        }
    }
}
