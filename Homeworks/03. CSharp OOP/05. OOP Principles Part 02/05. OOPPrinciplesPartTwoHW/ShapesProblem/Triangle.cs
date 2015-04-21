namespace ShapesProblem
{
    public class Triangle : Shape
    {
        public Triangle(double height, double width)
            : base(height, width)
        {

        }

        public override double CalculateSurface()
        {
            double surface = (base.Height * base.Width) / 2;
            return surface;
        }
    }
}
