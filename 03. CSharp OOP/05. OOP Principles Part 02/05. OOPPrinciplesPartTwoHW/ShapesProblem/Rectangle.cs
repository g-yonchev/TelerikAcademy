namespace ShapesProblem
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
            : base(height, width)
        {

        }

        public override double CalculateSurface()
        {
            double surface = base.Height * base.Width;
            return surface;
        }
    }
}
