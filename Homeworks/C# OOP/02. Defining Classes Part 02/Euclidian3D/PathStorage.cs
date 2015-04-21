namespace Euclidian3D
{
    using System;
    using System.IO;
    using System.Linq;

    public class PathStorage
    {
        public static Path LoadPath(StreamReader reader)
        {
            Path path = new Path();

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    int coordinatesStart = line.IndexOf("(");
                    string coordinates = line.Substring(coordinatesStart + 1, 7);

                    int[] pointCoordinates = coordinates.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

                    Point3D point = new Point3D(pointCoordinates[0], pointCoordinates[1], pointCoordinates[2]);
                    path.AddPoint(point);

                    line = reader.ReadLine();
                }
            }

            return path;
        }

        public static void SavePath(Path path, StreamWriter writer)
        {
            using (writer)
            {
                writer.Write(path.ToString());
            }
        }
    }
}
