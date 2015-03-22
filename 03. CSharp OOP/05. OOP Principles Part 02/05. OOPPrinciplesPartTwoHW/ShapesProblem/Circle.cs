namespace ShapesProblem
{
    using System;

    public class Circle : Shape
    {

        public Circle(double decimetar)
            : base(decimetar)
        {

        }

        public override double CalculateSurface()
        {
            double surface = (this.Height / 2) * (this.Height / 2) * Math.PI;
            return surface;
        }
    }
}
