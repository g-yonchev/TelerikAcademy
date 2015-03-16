namespace Euclidian3D
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> list;

        public Path()
        {
            this.list = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.list.Add(point);
        }

        public override string ToString()
        {
            string result = string.Join(" -> ", this.list);
            return result;
        }
    }
}
