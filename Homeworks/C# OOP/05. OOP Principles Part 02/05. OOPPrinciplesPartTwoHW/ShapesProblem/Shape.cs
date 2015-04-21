namespace ShapesProblem
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Shape(double size)
        {
            this.Height = size;
            this.Width = size;
        }

        public double Width 
        {
            get
            {
                return this.width;
            }
            set
            {
                ValidateSize(value);
                
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                ValidateSize(value);

                this.height = value;
            }
        }

        public virtual double CalculateSurface()
        {
            return 0;
        }

        private void ValidateSize(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
