using System;
using Estates.Interfaces;

namespace Estates.Data
{
    class Garage : Estate, IGarage
    {
        private const int MinWidthHeight = 0;
        private const int MaxWidthHeight = 500;

        private int width;
        private int height;

        public Garage()
        {
            this.Type = EstateType.Garage;
        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value < MinWidthHeight || value > MaxWidthHeight)
                {
                    throw new ArgumentOutOfRangeException(
                        String.Format("Width should be in range [{0}...{1}]",
                        MinWidthHeight, MaxWidthHeight));
                }
                this.width = value;
            }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                if (value < MinWidthHeight || value > MaxWidthHeight)
                {
                    throw new ArgumentOutOfRangeException(
                        String.Format("Height should be in range [{0}...{1}]",
                        MinWidthHeight, MaxWidthHeight));
                } 
                this.height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", Width: " + this.width + ", Height: " + this.Height;
        }
    }
}
