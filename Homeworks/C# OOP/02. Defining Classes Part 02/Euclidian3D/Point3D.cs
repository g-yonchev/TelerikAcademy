namespace Euclidian3D
{
    using System.Text;

    public struct Point3D
    {
        private static readonly Point3D startPoint;

        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            string result = string.Format("{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);
            return result;
        }
    }
}
