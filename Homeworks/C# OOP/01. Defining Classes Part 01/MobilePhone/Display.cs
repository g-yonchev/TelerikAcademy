namespace MobilePhone
{
    using System;

    public class Display
    {
        private double size;
        private int colors;

        public Display()
        {
            ;
        }

        public Display(int size)
        {
            this.Size = size;
        }

        public Display(int size, int colors)
            :this(size)
        {
            this.Colors = colors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0.0 || value > 20.0)
                {
                    throw new ArgumentOutOfRangeException("Size of display must be at range 0 and 20");
                }
                this.size = value;
            }
        }

        public int Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentOutOfRangeException("Colors of display cannot be negative");
                }

                this.colors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Display: {0} inches, {1} colors", this.Size, this.Colors);
        }
    }
}
